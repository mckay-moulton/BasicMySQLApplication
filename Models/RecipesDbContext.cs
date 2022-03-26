using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class RecipesDbContext : DbContext  
    {
        //inherit from base options
        public RecipesDbContext(DbContextOptions<RecipesDbContext> options) : base (options)
        {

        }
        //we are going to collect a set of individual recipes (singular), and when we bundle them together
        //we will call it recipes (plural), that we can access.
        public DbSet<Recipe> Recipes { get; set; }
    }
}
