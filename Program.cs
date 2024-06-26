using RecipeManagementModels;
using RecipeManagementServices;
using System;

namespace RecipeManagementConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeServices recipeServices = new RecipeServices();

            
            var recipes = recipeServices.GetAllRecipes();

            foreach (var recipe in recipes)
            {
                Console.WriteLine($"Recipe: {recipe.Title}");
                Console.WriteLine($"Ingredients: {string.Join(", ", recipe.Ingredients)}");
                Console.WriteLine($"Instructions: {recipe.Instructions}");
                Console.WriteLine();
            }       
        }
    }
}
