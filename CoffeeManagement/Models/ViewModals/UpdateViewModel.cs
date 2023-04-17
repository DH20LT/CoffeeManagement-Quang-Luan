using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CoffeeManagement.Models.ViewModals
{
    public class UpdateViewModel
    {
        [Required(ErrorMessage = "Please enter your ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your department")]
        public string? Department { get; set; }
        public string? PhotoPath { get; set; }
    }
}
