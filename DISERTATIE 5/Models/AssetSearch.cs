﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DISERTATIE_5.Models
{
    public class AssetSearch
    {

        public decimal asset_id { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string description { get; set; }
    }
}