using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRatings.Models;

namespace WebApplicationRatings.Data
{
    public class WebApplicationRatingsContext : DbContext
    {
        public WebApplicationRatingsContext(DbContextOptions<WebApplicationRatingsContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRatings.Models.RankingItem>? RankingItem { get; set; }
    }
}
