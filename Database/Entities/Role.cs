﻿using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Role
    {
        [Key]

        public int RoleId { get; set; }
        [Required]
        public string? RoleName { get; set; }
    }
}
