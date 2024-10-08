﻿using System.ComponentModel.DataAnnotations;

namespace eCommerceWebsite.Models
{
    public class Member
    {
        /// <summary>
        /// Uniquely identifies each member
        /// </summary>
        [Key]
        public int MemberId { get; set; }

        public string Email { get; set; }

        public string? Username { get; set; }

        public string Password { get; set; }

        public string? Phone { get; set; }
    }

    public class RegisterViewModel
    {
        // For some reason, is required in the
        // generation of a view model
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(Email))]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        // For some reason, is required in the
        // generation of a view model
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
