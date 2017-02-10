using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Country { get; set; }
        public string ActivityType { get; set; }
       
        public virtual ICollection<Review> Reviews { get; set; }
    }
}