using RecipeManagementData;
using RecipeManagementModels;
using System.Collections.Generic;

namespace RecipeManagementServices
{
    public class RecipeServices
    {
        private RecipeData recipeData = new RecipeData();

        public List<Recipe> GetAllRecipes()
        {
            return recipeData.GetRecipes();
        }

        public Recipe GetRecipeById(int id)
        {
            var recipes = recipeData.GetRecipes();
            return recipes.Find(r => r.Id == id);
        }

        public int AddRecipe(Recipe recipe)
        {
            return recipeData.AddRecipe(recipe);
        }

        public bool UpdateRecipe(Recipe recipe)
        {
            return recipeData.UpdateRecipe(recipe) > 0;
        }

        public bool DeleteRecipe(int id)
        {
            return recipeData.DeleteRecipe(id) > 0;
        }
    }
}
