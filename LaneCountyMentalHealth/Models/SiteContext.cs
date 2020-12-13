using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Models
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options) { } 
        public DbSet<Link> Links { get; set; }
        public DbSet<HomeForum> HomeForum { get; set;}
        public DbSet<FeedbackForum> FeedbackForum { get; set; }
    }
}
