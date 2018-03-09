using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobotReviewSite1._0.Models
{
    public class Robot
    {
        [Key]
        public int RobotID { get; set; }
        public string Name { get; set; }
        [Display(Name = "First Appearance")]
        public string FirstAppearsIn { get; set; }
        [Display(Name = "Creator")]
        public string CreatedBy { get; set; }
        [Display(Name = "For good")]
        public bool IsGood { get; set; }
        [Display(Name = "For evil")]
        public bool IsEvil { get; set; }

        [ForeignKey("Category"), Display(Name = "Function")]
        
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}