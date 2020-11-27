﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ReHomeVirtualBackEnd.Membership.Resources
{
    public class SavePlanResource
    {
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public double Cost { get; set; }

        [Required]
        public int MaxSession { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }

        [Required]
        public DateTime UpdateAt { get; set; }

        public int SubscruptionId { get; set; }
    }
}
