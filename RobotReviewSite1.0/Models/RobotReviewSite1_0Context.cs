using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RobotReviewSite1._0.Models
{
    public class RobotReviewSite1_0Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RobotReviewSite1_0Context() : base("name=RobotReviewSite1_0Context")
        {
        }

        public System.Data.Entity.DbSet<RobotReviewSite1._0.Models.Robot> Robots { get; set; }

        public System.Data.Entity.DbSet<RobotReviewSite1._0.Models.Category> Categories { get; set; }
    }
}
