using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseManagement.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        string Password;

        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string CMND { get; set; }
        
    }
}
