using Microsoft.AspNetCore.Mvc;
using static IPB1.ChartApp.Models.BarChartModel;

namespace IPB1.ChartApp.Controllers
{
    public class BarChartController : Controller
    {
        public IActionResult BarChart()
        {
            var barChartData = new List<BarChartDto>
            {
                new BarChartDto { name = "Chrome", y = 63.06f, drilldown = "Chrome" },
                new BarChartDto { name = "Safari", y = 19.84f, drilldown = "Safari" },
                new BarChartDto { name = "Firefox", y = 4.18f, drilldown = "Firefox" },
                new BarChartDto { name = "Edge", y = 4.12f, drilldown = "Edge" },
                new BarChartDto { name = "Opera", y = 2.33f, drilldown = "Opera" },
                new BarChartDto { name = "Internet Explorer", y = 0.45f, drilldown = "Internet Explorer" },
                new BarChartDto { name = "Other", y = 1.582f, drilldown = null }
            };


            return View(barChartData);
        }
    }
}
