using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(string section)
        {
            var acceptedSection = new List<string>()
            {
                "registered",
                "subscribed"
            };

            if (string.IsNullOrWhiteSpace(section) || !acceptedSection.Contains(section, comparer: StringComparer.OrdinalIgnoreCase))
            {
                return Redirect("http://www.sigmasolve.net");
            }

            ViewBag.Section = section.ToLower();

            return View();

        }
    }
}
