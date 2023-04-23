using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CoffeeManagement.Models.ViewModals;
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
        public Boolean dangnhap(string email, string password)
        {
            if (email == 50 )
            {
                return true;
            }    
        }
        public void Update() 
        {
            
        }
    }
}
