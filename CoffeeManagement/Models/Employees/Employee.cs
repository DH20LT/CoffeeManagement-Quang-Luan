using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoffeeManagement.Models.Employees
{
    public class Employee
    {
        [BindNever]
        [Key]
        [Required(ErrorMessage = "Please enter your ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your department")]
        public string? Department { get; set; }
        public string? PhotoPath { get; set; }
    }
}
