using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_commerce.DTO
{
    public class UserSignUpDTO
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public int Phone_Number { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}