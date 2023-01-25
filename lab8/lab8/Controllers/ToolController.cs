using lab8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Collections;
using System;

namespace lab8.Controllers
{
    public class ToolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Tool/Solve/{a}/{b}/{c}")]
        public IActionResult Zad1(int a, int b, int c)
        {
            ViewData["equation"] = lab5zad1.Program.GetEquationStr(a, b, c);
            (float x1, float x2, string solutionStr, bool inf) = lab5zad1.Program.CheckNumberOfSolutions(a, b, c);

            if (float.IsNaN(x1) && float.IsNaN(x2))
            {
                ViewData["solutionsCount"] = 0;
                if (inf)
                {
                    ViewBag.cls = "inf";
                }
                else
                {
                    ViewBag.cls = "t0";
                }
            }
            else if (!float.IsNaN(x1) && float.IsNaN(x2))
            {
                ViewData["solutionsCount"] = 1;
                ViewBag.cls = "t1";
                ViewBag.x1 = x1;
            }
            else
            {
                ViewData["solutionsCount"] = 2;
                ViewBag.cls = "t2";
                ViewBag.x1 = x1;
                ViewBag.x2 = x2;
            }
            ViewData["solutionStr"] = solutionStr;
            return View();
        }
    }
}
