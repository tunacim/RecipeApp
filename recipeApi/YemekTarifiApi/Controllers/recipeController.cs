using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace YemekTarifiApi.Controllers
{
    [Route("[controller]")]
    public class recipeController : Controller
    {
      [HttpGet]
public IActionResult Get()
{
    var recipes = GetRecipes();
    return Ok(recipes);
}

[HttpGet("{id}")]
public IActionResult GetById(int id)
{
    var recipe = GetRecipes().FirstOrDefault(r => r.Id == id);
    if (recipe == null)
    {
        return NotFound();
    }
    return Ok(recipe);
}

private List<Recipe> GetRecipes()
{
    var recipe1 = new Recipe { Id = 1, Name = "Pizza Margherita", Description = "A classic pizza with tomato sauce, mozzarella and basil." ,recipe="On a lightly floured surface, stretch one ball of dough into a 13-inch round; transfer to a floured pizza peel, adding flour where the dough sticks. Spread 1/4 cup of the tomato sauce over the dough to within 1 inch of the edge. Spread one-fourth of the cheese over the pizza and drizzle with 1 tablespoon of oil. Season with sea salt and pepper and slide the pizza onto the stone. Bake until the bottom is charred and the cheese is melted, about 8 minutes. Scatter one-fourth of the basil on top and let stand for 3 minutes before serving. Repeat with the remaining dough and toppings."};
    var recipe2 = new Recipe { Id = 2, Name = "Spaghetti Bolognese", Description = "Spaghetti with a meaty tomato sauce." ,recipe=" Drain the spaghetti and either stir into the bolognese sauce, or serve the sauce on top. Serve with more grated parmesan, the remaining basil leaves and crusty bread, if you like."};

    return new List<Recipe> { recipe1, recipe2 };
}

    }
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string recipe{ get; set; }
    }
}

