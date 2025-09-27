using Microsoft.AspNetCore.Mvc;
using house_company.Models;
using System.Diagnostics;

namespace house_company.Controllers
{
    public class HomeController : Controller
    {
        // [HttpGet] - Responsible for displaying the form
        public IActionResult Index()
        {
            return View(new HouseModel());
        }

        // [HttpPost] - Responsible for handling the submission of data
        [HttpPost]
        public IActionResult Index(HouseModel model)
        {
            // CHECK 1: Use ModelState.IsValid to run the [Required] validation checks
            if (ModelState.IsValid)
            {
                // If the model is valid, proceed with processing (console output)
                Debug.WriteLine("--- Submitted House Data ---");
                Debug.WriteLine($"House Type: {model.HouseType}");
                Debug.WriteLine($"House Location: {model.HouseLocation}");
                Debug.WriteLine("--------------------------");

                // Return the valid model to the view for display
                return View(model);
            }

            // CHECK 2: If validation fails (ModelState is NOT valid), return the model
            // back to the view. This allows the view to display the validation errors.
            return View(model);
        }
    }
}