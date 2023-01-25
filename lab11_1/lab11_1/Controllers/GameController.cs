using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace lab11_1.Controllers
{
    public class GameController : Controller
    {

        //  static int n = -1;
        //  static int randValue = -1;
        //  static int roundNumber = 0;

        static Random random = new();
        //  static List<int> gameHistory = new();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Set(int param)
        {
            if (param <= 0) 
            {
                HttpContext.Session.SetInt32("n", 10);
                ViewBag.message = "Range value you provided was not appropriate, " +
                    "so it got automatically set with boundaries from 0 to 10" +
                    "Go to /Draw to generate a random value.";
            }
            else
            {
                HttpContext.Session.SetInt32("n", param);
                ViewBag.message = $"Selected range is from 0 to {(int)HttpContext.Session.GetInt32("n")}" + 
                    "\nGo to /Draw to generate a random value.";
            }

            //  gameHistory.Clear();
            return View("Set");
        }

        public IActionResult Draw()
        {
            int randValue = random.Next(0, (int)HttpContext.Session.GetInt32("n"));
            HttpContext.Session.SetInt32("randValue", randValue);
            HttpContext.Session.SetInt32("roundNumber", 0);
            
            ViewBag.message = $"Generated a random value within [0,{(int)HttpContext.Session.GetInt32("n")}]." + 
                " Go to /Guess,<n> to guess a value from that range";
            //  gameHistory.Clear();
            HttpContext.Session.SetString("history", "");
            return View("Draw");
        }

        public IActionResult Guess(int guessedNumber)
        {
            //  gameHistory.Add(guessedNumber);
            //  ViewBag.gameHistory = gameHistory;
            ViewBag.guess = guessedNumber;
            int randValue = (int)HttpContext.Session.GetInt32("randValue");

            string history = HttpContext.Session.GetString("history");
            string tmp = " - " + guessedNumber as string;
            history = history + tmp;
            HttpContext.Session.SetString("history", history);
            ViewBag.history = history;
            int count = (int)HttpContext.Session.GetInt32("roundNumber");
            HttpContext.Session.SetInt32("roundNumber", ++count);
            ViewBag.roundNumber = count;

            if (guessedNumber == randValue)
            {
                ViewBag.message = "Correct!";
                ViewBag.roundNumber = (int)HttpContext.Session.GetInt32("roundNumber");
                //ViewBag.clue = "accurate";
            }
            else if (guessedNumber > randValue)
            {
                ViewBag.message = "Too big!";
                //ViewBag.clue = "overshot";
            }
            else
            {
                ViewBag.message = "Too low!";
                //ViewBag.clue = "undershot";
            }

            return View("Guess");
        }

    }
}
