﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Models
{
    public class Pickups
    {
        [Key]
        public int Id { get; set; }

        // customer FK
    }
}