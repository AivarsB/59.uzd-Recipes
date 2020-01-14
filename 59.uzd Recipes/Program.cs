using System;
using System.Collections.Generic;
using System.Linq;

namespace _59.uzd_Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.versija

            var ingredients = new List<Ingredient>      // element
            {   new Ingredient() {Name = "milti", Amount = 5000},
                new Ingredient() {Name = "cukurs", Amount = 1000},
                new Ingredient() {Name = "udens", Amount = 5000},
                new Ingredient() {Name = "piens", Amount = 100},
                new Ingredient() {Name = "sviests", Amount = 100}
            };

            var recipe = new List<Ingredient>       // item
            {   new Ingredient() {Name = "piens", Amount = 100},
                new Ingredient() {Name = "cukurs", Amount = 50},
                new Ingredient() {Name = "milti", Amount = 100},
                new Ingredient() {Name = "sviests", Amount = 100}
            };

            int recipeLength = recipe.Count;

            bool[] atbildes = new bool[recipeLength];
            var i = 0;

            foreach (var item in recipe)
            {
                foreach (var element in ingredients)
                {
                    if (item.Name == element.Name && item.Amount <= element.Amount)
                    {
                        atbildes[i] = true;
                        i++;
                    }
                }
            }

            bool endAnswer = false;

            foreach (var atbilde in atbildes)
            {
                if (atbilde)
                {
                    endAnswer = true;
                }
                else
                {
                    endAnswer = false;
                }
            }

            if (endAnswer)
            {
                Console.WriteLine("Recepte gatava");
            }
            else
            {
                Console.WriteLine("Recepti nevar pagatavot");
            }

            // 2.versija

            var PreparedIngredients = new List<Ingredient>
            {   new Ingredient() {Name = "milti", Amount = 5000},
                new Ingredient() {Name = "cukurs", Amount = 1000},
                new Ingredient() {Name = "udens", Amount = 5000},
                new Ingredient() {Name = "piens", Amount = 100},
                new Ingredient() {Name = "sviests", Amount = 100}
            };

            var RecipeIngredients = new List<Ingredient>
            {   new Ingredient() {Name = "piens", Amount = 100},
                new Ingredient() {Name = "cukurs", Amount = 50},
                new Ingredient() {Name = "milti", Amount = 100},
                new Ingredient() {Name = "sviests", Amount = 100}
            };

            Recipe recipe1 = new Recipe();
            Console.WriteLine(recipe1.Make(RecipeIngredients, PreparedIngredients));
        }
    }
}
// Izveidot divas klases Ingredient (sastāvdaļa) un Recipe (recepte). 
// Izdomājiet, kādas īpašības ir nepieciešamas abām klasēm. 
// Klasē Recipe ir jābūt metodei Make, kurai ir jāpārbauda vai ir visas nepieciešamās sastāvdaļas, 
// lai pagatavotu šo ēdienu. Ja ir visas sastāvdaļas, metodei jāatgriež teksts “ēdiens gatavs", 
// vai, ka nav iespējams konkrēto recepti pagatavot.
