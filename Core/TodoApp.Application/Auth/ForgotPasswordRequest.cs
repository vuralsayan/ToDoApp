﻿#nullable disable
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Application.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
