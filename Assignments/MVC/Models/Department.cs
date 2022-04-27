using System.ComponentModel.DataAnnotations;

namespace EmployeeMVC.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
