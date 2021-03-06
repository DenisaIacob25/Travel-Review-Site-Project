﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string City { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        [Display (Name ="Date: mm/dd/yyyy")]
        public DateTime DatePosted { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}