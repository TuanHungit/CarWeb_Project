﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class ProductBrand
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Brand Name")]
        public string Name { get; set; }
    }
}
