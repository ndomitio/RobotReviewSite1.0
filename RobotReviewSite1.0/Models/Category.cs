using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobotReviewSite1._0.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Function { get; set; }

        //Navigation Property 

        public virtual ICollection<Robot>Robots { get; set; }  
    }
}