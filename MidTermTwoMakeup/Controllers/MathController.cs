using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidTermTwoMakeup.Models;
using MathLib;


namespace MidTermTwoMakeup.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DoCalculation()
        {
            
            MathOperation model = new MathOperation();

            return View(model);
        }

        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation model)
        {
            
            switch (model.Operator)
            {
                case "+":
                model.Result = MathRoutines.Add(model.LeftOperand, model.RightOperand);
                break;

                case "-":
                model.Result = MathRoutines.Subtract(model.LeftOperand, model.RightOperand);
                break;

                case "*":
                model.Result = MathRoutines.Multiply(model.LeftOperand, model.RightOperand);
                break;

                case "/":
                model.Result = MathRoutines.Divide(model.LeftOperand, model.RightOperand);
                break;

                default:
                ViewData["Message"] = "Incorrect Operator";
                break;
            }

           

            return View(model);
        }
    }
}

