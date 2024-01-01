﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizTime.Domain.Common;
using QuizTime.Domain.Entities.Admins;
using QuizTime.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace QuizTime.Service.Dtos.Admins
{
    public class AdminUpdateDto : BaseEntity
    {
        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; } = String.Empty;

        [AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".webp" }), MaxFile(2)]
        public IFormFile? Image { get; set; }
        public string? ImagePath { get; set; }

        [Required(ErrorMessage = "Phone Number Required")]
        [Phone(ErrorMessage = "The phone number was entered incorrectly")]
        [Remote("IsPhoneAvailable", "Check", HttpMethod = "POST", ErrorMessage = "A phone number with this name has already been registered!")]
        public string PhoneNumber { get; set; } = String.Empty;

        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; } = String.Empty;

        public static implicit operator Admin(AdminUpdateDto dto)
        {
            return new Admin()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Image = dto.ImagePath,
                PhoneNumber = dto.PhoneNumber,
                BirthDate = dto.BirthDate,
                Address = dto.Address
            };
        }
    }
}
