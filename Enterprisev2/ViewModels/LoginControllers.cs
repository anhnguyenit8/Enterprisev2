using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enterprisev2.ViewModels
{
    public class LoginControllers
    {

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "This field is reqired!")]
        [DataType(DataType.EmailAddress)]

        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "This field is reqired!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
