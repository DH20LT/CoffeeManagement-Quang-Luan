using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeManagement.Models.ViewModals
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Lưu thông tin tài khoản?")]
        public bool RememberMe { get; set; }

        [Display(Name = "Đăng nhập nhanh")]
        public bool LoginFast { get; set; }

        public string ReturnUrl { get; set; }
    }
}
