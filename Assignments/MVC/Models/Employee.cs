using System.ComponentModel.DataAnnotations;

namespace EmployeeMVC.Models
{
    public class Employee
    {
        [Key]
        public int EnployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public int DesignationId { get; set; }
        public Designation? Designation { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
