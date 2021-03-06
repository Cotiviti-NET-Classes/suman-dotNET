using System.ComponentModel.DataAnnotations;

namespace EmployeeMVC.Models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        public string Name { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
