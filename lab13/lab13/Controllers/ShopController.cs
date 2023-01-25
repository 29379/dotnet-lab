using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab13.ViewModels;
using lab13.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System.Web;

namespace lab13.Controllers
{
    public class ShopController : Controller
    {
        private readonly Lab13DbContext _context;
        private Dictionary<int, CartItemViewModel> cart;
        private const int EXPIRATION = 14;


        public ShopController(Lab13DbContext context)
        {
            _context = context;
        }


        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var appDbContext = await _context.Articles.Include(a => a.Category).ToListAsync();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Current = null;
            return View(appDbContext);
        }

        public async Task<IActionResult> IndexList(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articles = await _context.Articles
                .Include(a => a.Category)
                .Where(a => a.CategoryId == id)
                .ToListAsync();

            ViewBag.Current = id;
            ViewBag.Categories = _context.Categories.ToList();

            return View("Index", articles);
        }

        [Authorize(Policy = "user")]
        public Dictionary<int, CartItemViewModel> GetCart()
        {
            Request.Cookies.TryGetValue("cart", out string str);
            if (str != null)
            {
                cart = JsonConvert.DeserializeObject<Dictionary<int, CartItemViewModel>>(Request.Cookies["cart"]);
            }
            else
            {
                cart = new Dictionary<int, CartItemViewModel>();
            }
            return cart;
        }

        public void SaveCart(Dictionary<int, CartItemViewModel> cart)
        {
            string cartToString = JsonConvert.SerializeObject(cart);
            //  string userToString = JsonConvert.SerializeObject(User.Identity.GetHashCode());
            CookieOptions options = new()
            {
                Expires = DateTime.Now.AddDays(EXPIRATION)
            };
            Response.Cookies.Append("cart", cartToString, options);
            
            //  Response.Cookies.Append("cart", userToString);
        }

        private bool CartItemExists(int id)
        {
            cart = GetCart();
            if (cart == null)
            {
                return false;
            }
            return cart.ContainsKey(id);
        }

        [Authorize(Policy = "user")]
        public async Task<IActionResult> Cart()
        {
            cart = GetCart();
            ViewBag.Total = GetTotalAsync();
            List<CartItemViewModel> basket = new();

            var keys = cart.Keys.ToList();
            var articles = await _context.Articles
                .Include(a => a.Category)
                .Where(a => keys.Contains(a.Id))
                .ToListAsync();

            foreach (var elem in articles)
            {
                basket.Add(new CartItemViewModel
                {
                    ArticleId = elem.Id,
                    Article = elem,
                    Quantity = cart[elem.Id].Quantity
                });
            }

            SaveCart(cart);
            return View(basket);
        }


        public decimal GetTotalAsync()
        {
            cart = GetCart();
            decimal? total = 0;
            if (cart == null)
            {
                return decimal.Zero;
            }

            var keys = cart.Keys.ToList();
            var articles = _context.Articles.ToList();

            foreach (KeyValuePair<int, CartItemViewModel> elem in cart)
            {
                if (articles.Where(a => a.Id == elem.Value.ArticleId).Any())
                {
                    total += (decimal?)elem.Value.Article.Price * elem.Value.Quantity;
                }
            }

            return (decimal)total;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "user")]
        public IActionResult AddCartItem(int id)
        {
            cart = GetCart();
            if (CartItemExists(id))
            {
                cart[id].Quantity++;
            }
            else
            {
                CartItemViewModel elem = new()
                {
                    ArticleId = id,
                    Article = _context.Articles
                        .SingleOrDefault(a => a.Id == id),
                    Quantity = 1
                };
                cart.Add(id, elem);
            }
            SaveCart(cart);
            return Redirect(HttpContext.Request.Headers["Referer"].ToString());

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "user")]
        public IActionResult ReduceCartItem(int id)
        {
            cart = GetCart();

            if (CartItemExists(id))
            {
                if (cart[id].Quantity <= 1)
                {
                    cart.Remove(id);
                }
                else
                {
                    cart[id].Quantity--;
                }
            }

            SaveCart(cart);
            return Redirect(HttpContext.Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "user")]
        public IActionResult DeleteCartItem(int id)
        {
            cart = GetCart();

            if (CartItemExists(id))
            {
                cart.Remove(id);
                SaveCart(cart);
            }

            return Redirect(HttpContext.Request.Headers["Referer"].ToString());
        }

        [Authorize]
        [Authorize(Policy = "user")]
        public async Task<IActionResult> PlaceOrder()
        {
            cart = GetCart();
            ViewBag.Total = GetTotalAsync();
            List<CartItemViewModel> basketList = new();

            var keys = cart.Keys.ToList();
            var articles = await _context.Articles.Include(a => a.Category).Where(a => keys.Contains(a.Id)).ToListAsync();

            foreach (var article in articles)
            {
                basketList.Add(new CartItemViewModel
                {
                    ArticleId = article.Id,
                    Article = article,
                    Quantity = cart[article.Id].Quantity
                });
            }

            ViewData["paymentMethod"] = new SelectList(new List<string> { "Card", "Blik" , "PayPal", "Cash"});

            OrderViewModel order = new()
            {
                Items = basketList
            };

            return View(order);
        }

        [Authorize]
        [HttpPost]
        [Authorize(Policy = "user")]
        public async Task<ActionResult> ConfirmOrderAsync([Bind("Name, Surname, Email, Phone, Address, ZipCode, Payment")] OrderViewModel order)
        {
            cart = GetCart();
            ViewBag.Total = GetTotalAsync();
            List<CartItemViewModel> basketList = new();

            var keys = cart.Keys.ToList();
            var articles = await _context.Articles.Include(a => a.Category).Where(a => keys.Contains(a.Id)).ToListAsync();

            foreach (var article in articles)
            {
                basketList.Add(new CartItemViewModel
                {
                    ArticleId = article.Id,
                    Article = article,
                    Quantity = cart[article.Id].Quantity
                });
                cart.Remove(article.Id);
            }

            order.Items = basketList;
            SaveCart(cart);

            return View(order);
        }
    }
}