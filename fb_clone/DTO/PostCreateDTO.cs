﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fb_clone.DTO
{
    public class PostCreateDTO
    {
        [Required]
        public string Content { get; set; }
    }
}