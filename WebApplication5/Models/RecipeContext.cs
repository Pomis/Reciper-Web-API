using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication5.Models
{
    public class RecipeContext: DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
    }
}