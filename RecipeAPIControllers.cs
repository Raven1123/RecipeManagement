using Microsoft.AspNetCore.Mvc;
using RecipeManagementServices;
using RecipeManagementModels;
using System.Collections.Generic;

namespace RecipeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeServices _recipeServices;

        public RecipesController()
        {
            _recipeServices = new RecipeServices();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetAllRecipes()
        {
            return _recipeServices.GetAllRecipes();
        }

        [HttpGet("{id}")]
        public ActionResult<Recipe> GetRecipeById(int id)
        {
            var recipe = _recipeServices.GetRecipeById(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return recipe;
        }

        [HttpPost]
        public ActionResult AddRecipe([FromBody] Recipe recipe)
        {
            int result = _recipeServices.AddRecipe(recipe);
            if (result > 0)
            {
                return CreatedAtAction(nameof(GetRecipeById), new { id = recipe.Id }, recipe);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRecipe(int id, [FromBody] Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return BadRequest();
            }

            bool result = _recipeServices.UpdateRecipe(recipe);
            if (result)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRecipe(int id)
        {
            bool result = _recipeServices.DeleteRecipe(id);
            if (result)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
