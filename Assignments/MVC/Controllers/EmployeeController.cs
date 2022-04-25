using Microsoft.AspNetCore.Mvc;
using MvcProject1.Models;
using MvcProject1.Models.Employee;
using System.Diagnostics;

namespace MvcProject1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<Employee> _logger;

        public EmployeeController(ILogger<Employee> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var a = "This is Suman's View";
            return View(a);
            
        }

        public IActionResult Details()
        {
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(new Employee
            {
                Id = 1,
                Name = "Dipesh Chapagin",
                Address = "Kathmandu",
                Phone = "9876543210",
                Salary = 50000,
                Department = "Dot Net"
            });
            listEmployee.Add(new Employee
            {
                Id = 2,
                Name = "Nabin Kandel",
                Address = "Kirtipur",
                Phone = "9800216548",
                Salary = 45000,
                Department = "Java"
            });
            listEmployee.Add(new Employee
            {
                Id = 3,
                Name = "Nirmal Budhathoki",
                Address = "Bhaktpur",
                Phone = "985461257",
                Salary = 40000,
                Department = "Dev Ops"
            });
            listEmployee.Add(new Employee
            {
                Id = 4,
                Name = "Jidesh Govinda",
                Address = "Lalitpur",
                Phone = "975461258",
                Salary = 42000,
                Department = "QA"
            });
            return View(listEmployee.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}