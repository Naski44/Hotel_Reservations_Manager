﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class User:IdentityUser
    {
        [Key]
        public Guid EGN {  get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateOnly HireDate { get; set; }
        public bool Active { get; set; }
        public DateOnly ?ReleaseDate { get; set; } = null;
    }
}
