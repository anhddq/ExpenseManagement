using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseManagement.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        string Password;
    }
}
