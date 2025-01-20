using BmiCalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BmiCalculatorApp.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet()]
        public IActionResult Index()
        {
            // return default view:
            return View(new BmiViewModel());
        }

        [HttpPost()]
        public IActionResult Index(BmiViewModel bmiViewModel)
        {
            if (ModelState.IsValid)
            {
                bmiViewModel.BmiValue = BmiViewModel.CalculateBmi(bmiViewModel.Weight, bmiViewModel.Height);

                bmiViewModel.BmiSummary = BmiViewModel.GetBmiResultSummary(bmiViewModel.BmiValue);

                return View(bmiViewModel);
            }
            else
            {
                return View(bmiViewModel);
            }
        }
    }
}
