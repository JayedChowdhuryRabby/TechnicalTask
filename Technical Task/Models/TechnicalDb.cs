using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Technical_Task.Models
{
    public class TechnicalDb : DbContext
    {
        public TechnicalDb() : base("name=TechnicalDb")
        {
            // Log database commands to console
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }
        public DbSet<TotalSum> TotalSums { get; set; }
    }
}