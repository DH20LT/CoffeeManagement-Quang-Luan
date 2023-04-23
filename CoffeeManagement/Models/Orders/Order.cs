using CoffeeManagement.Models.ViewModals;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace CoffeeManagement.Models.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
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
        class RegisterViewModel
        {
            public RegisterViewModel(string email, string fullname, string password, string confirmpassword)
            {
                Email = email;
                Password = password;
            }
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
