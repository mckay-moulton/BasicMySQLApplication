using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class Recipe
    {
        [Key]
        [Required]
        public int RecipeID { get; set; }
        public string RecipeTitle { get; set; }
        public int RecipeClassID { get; set; }
        public string Preparation { get; set; }
        public string Notes { get; set; }
    }
}
