using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _59.uzd_Recipes
{
    public class Recipe
    {
        // 1.versija 

        public List<Ingredient> recipe { get; set; }

        // 2.versija

        public List<Ingredient> RecipeIngredients { get; set; }
        public List<Ingredient> PreparedIngredients { get; set; }

        public string Make(List<Ingredient> RecipeIngredients, List<Ingredient> PreparedIngredients)
        {
            // check if all ingredients are present
            bool present = RecipeIngredients.All(i => PreparedIngredients.Any(a => a.Name == i.Name));
            if (!present)
            {
                return "Nav visi ingredienti";
            }

            // check if the amount if sufficient
            bool enough = RecipeIngredients.All(i => i.Amount <= PreparedIngredients.First(a => a.Name == i.Name).Amount);
            if (!enough)
            {
                return "Nav pietiekams daudzums";
            }
            return "Rijamais gatavs";
        }
    }
}

