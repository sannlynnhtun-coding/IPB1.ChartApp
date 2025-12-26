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

        public IActionResult HighChartColumn()
        {
            var data = new List<SimpleChartDto>
            {
                new SimpleChartDto { Label = "Q1", Value = 1500 },
                new SimpleChartDto { Label = "Q2", Value = 2300 },
                new SimpleChartDto { Label = "Q3", Value = 3200 },
                new SimpleChartDto { Label = "Q4", Value = 4500 }
            };
            return View(data);
        }

        // 2. ApexCharts - Line Chart
        public IActionResult ApexChartLine()
        {
            var data = new List<SimpleChartDto>
            {
                new SimpleChartDto { Label = "Jan", Value = 30 },
                new SimpleChartDto { Label = "Feb", Value = 40 },
                new SimpleChartDto { Label = "Mar", Value = 35 },
                new SimpleChartDto { Label = "Apr", Value = 50 },
                new SimpleChartDto { Label = "May", Value = 49 },
                new SimpleChartDto { Label = "Jun", Value = 60 }
            };
            return View(data);
        }

        // 3. ChartJs - Doughnut Chart
        public IActionResult ChartJsDoughnut()
        {
            var data = new List<SimpleChartDto>
            {
                new SimpleChartDto { Label = "Mobile", Value = 300 },
                new SimpleChartDto { Label = "Desktop", Value = 100 },
                new SimpleChartDto { Label = "Tablet", Value = 50 }
            };
            return View(data);
        }

        // 4. CanvasJS - Spline Area Chart
        public IActionResult CanvasJsSpline()
        {
            // CanvasJS usually expects { label, y }
            var data = new List<SimpleChartDto>
            {
                new SimpleChartDto { Label = "Monday", Value = 10 },
                new SimpleChartDto { Label = "Tuesday", Value = 15 },
                new SimpleChartDto { Label = "Wednesday", Value = 25 },
                new SimpleChartDto { Label = "Thursday", Value = 30 },
                new SimpleChartDto { Label = "Friday", Value = 28 }
            };
            return View(data);
        }
    }
}

    public class PieChartDto
    {
        public string name { get; set; }
        public bool sliced { get; set; }
        public bool selected { get; set; }
        public float y { get; set; }
    }
public class SimpleChartDto
{
    public string Label { get; set; } // X-Axis or Name
    public double Value { get; set; } // Y-Axis or Data
}


