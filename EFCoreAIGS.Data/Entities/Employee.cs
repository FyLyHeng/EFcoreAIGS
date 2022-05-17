﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAIGS.Data.Entities
{
    public class Employee
    {
   
        public Employee()
        {
            SpendingDetails = new List<SpendingDetails>();
        }
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Hired { get; set; }
       
        [NotMapped]
        public decimal TotalSpendings { get; set; }

        public List<SpendingDetails> SpendingDetails { get; set; }

    }
}
