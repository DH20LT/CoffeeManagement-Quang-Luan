using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace CoffeeManagement.Models.Customers
{
    public class Customer
    {
        [BindNever]
        [Key]
        [Required(ErrorMessage = "Please enter your ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string? Email { get; set; }
        public string? PhotoPath { get; set; }
        class LoginViewModel
        {
            public LoginViewModel(string email, string password)
            {
                Email = email;
                Password = password;
            }
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
