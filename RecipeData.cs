using RecipeManagementModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RecipeManagementData
{
    public class RecipeData
    {
        private string connectionString = "YourConnectionString";

        public List<Recipe> GetRecipes()
        {
            return new List<Recipe>();
        }

        public int AddRecipe(Recipe recipe)
        {
            return 1;
        }

        public int UpdateRecipe(Recipe recipe)
        {
            return 1;
        }

        public int DeleteRecipe(int recipeId)
        {
            return 1;
        }
    }
}
