﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetCreativity1.Repositories.DTOs.User
{
    public class UserUpdateDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public bool IsConfirmed { get; set; }
    }
}