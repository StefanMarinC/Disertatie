﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DISERTATIE_5.Models
{
    public class AddDebt
    {
        [Display(Name = "Item date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime item_date { get; set; }

        [Display(Name = "Amount")]
        [Required]
        [Range(0.01, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public float amount { get; set; }

        [Display(Name = "Currency")]
        [Required]
        public string currency { get; set; }
    }
}