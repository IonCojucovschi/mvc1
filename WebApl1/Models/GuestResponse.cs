using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApl1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]///validarile adica cand se va rula programul aceste campuri numai decit vor trebui indeplinite.
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\+",ErrorMessage ="Please enter a valid email addres")]// aici se arata forma care trebuie sa o aiba emailul pentru a fi acceptat.
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }

    }
}