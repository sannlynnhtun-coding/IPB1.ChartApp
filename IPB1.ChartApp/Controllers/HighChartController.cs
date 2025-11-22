using Microsoft.AspNetCore.Mvc;

namespace IPB1.ChartApp.Controllers
{
    public class HighChartController : Controller
    {
        public IActionResult PieChart()
        {
            var pieChartData = new List<PieChartDto>
{
    new PieChartDto
    {
        name = "Water",
        sliced = false,
        selected = false,
        y = 55.02f
    },
    new PieChartDto
    {
        name = "Fat",
        sliced = true,
        selected = true,
        y = 26.71f
    },
    new PieChartDto
    {
        name = "Carbohydrates",
        sliced = false,
        selected = false,
        y = 1.09f
    },
    new PieChartDto
    {
        name = "Protein",
        sliced = false,
        selected = false,
        y = 15.5f
    },
    new PieChartDto
    {
        name = "Ash",
        sliced = false,
        selected = false,
        y = 1.68f
    }
};
            return View(pieChartData);
        }
    }

    public class PieChartDto
    {
        public string name { get; set; }
        public bool sliced { get; set; }
        public bool selected { get; set; }
        public float y { get; set; }
    }
}
