using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeFirst.EF.Models
{
    public class User
    {
        [Key]
        [Required]

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    }
}