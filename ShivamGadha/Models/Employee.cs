using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShivamGadha.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public string EmpCity { get; set; }
        public string EmpDepartment { get; set; }
        public string EmpManager { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Salary { get; set; }
    }
}
