using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace lab8.Controllers
{
    public class GameController : Controller
    {

        static int n = -1;
        static int randValue = -1;
        static int roundNumber = 0;

        static Random random = new Random();
        static List<int> gameHistory = new List<int>();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Set,{param}")]
        public IActionResult Set(int param)
        {
            if (param <= 0) 
            {
                n = 10;
                ViewBag.message = "Range value you provided was not appropriate, " +
                    "so it got automatically set with boundaries from 0 to 10" +
                    "Go to /Draw to generate a random value.";
            }
            else
            {
                n = param;
                ViewBag.message = $"Selected range is from 0 to {n-1}" + 
                    "\nGo to /Draw to generate a random value.";
            }
            gameHistory.Clear();
            return View("Set");
        }

        [Route("Draw")]
        public IActionResult Draw()
        {
            if (n <= 0)
            {
                n = 10;
            }
            randValue = random.Next(0, n);
            
            roundNumber = 1;
            ViewBag.message = $"Generated a random value within [0,{n-1}]." + 
                " Go to /Guess,<n> to guess a value from that range";
            gameHistory.Clear();
            return View("Draw");
        }

        [Route("Guess,{param}")]
        public IActionResult Guess(int param)
        {
            gameHistory.Add(param);
            ViewBag.gameHistory = gameHistory;
            ViewBag.guess = param;

            if (randValue < 0)
            {
                if (n <= 0)
                {
                    n = 10;
                }
                randValue = random.Next(0, n);
            }

            if (param > n-1)
            {
                ViewBag.message = "Out of bounds - too big!";
                ViewBag.cls = "overshot";
                ViewBag.round = roundNumber++;
            }
            else if (param < 0)
            {
                ViewBag.message = "Out of bounds - too low!";
                ViewBag.cls = "undershot";
                ViewBag.round = roundNumber++;
            }
            else if (param == randValue)
            {
                ViewBag.message = "Correct!";
                ViewBag.cls = "accurate";
                ViewBag.round = roundNumber;
            }
            else if (param > randValue)
            {
                ViewBag.message = "Too big!";
                ViewBag.cls = "overshot";
                ViewBag.round = roundNumber++;
            }
            else
            {
                ViewBag.message = "Too low!";
                ViewBag.cls = "undershot";
                ViewBag.round = roundNumber++;
            }

            return View("Guess");
        }

    }
}
