﻿using System;
using System.ComponentModel.DataAnnotations;
namespace PartyInvites_Ass2_WilsonGuaman.Models
{
    public class GuestRespose
    {
        [Required(ErrorMessage = "Please enter your name")]
       public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your email address")]
        [EmailAddress]
       public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your phone number")]
       public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you'll attend")]
       public bool? WillAttend { get; set; }

    }
}
