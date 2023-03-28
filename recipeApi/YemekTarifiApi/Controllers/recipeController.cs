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
   

Recipe fishAndChips = new Recipe()
{
    Name = "Fish and chips",
  Id=1,
    Description = "A British classic, fish and chips consists of deep-fried battered fish and thick-cut potato fries. Serve with salt, vinegar, and tartar sauce.",
    recipe = "- Cut potatoes into thick fries and soak in cold water for 30 minutes.\n- Heat oil in a deep fryer or heavy pot.\n- Coat fish fillets in seasoned flour, dip in beer batter, and deep-fry until golden.\n- Drain fries, season with salt, and serve with fried fish and tartar sauce."
};

Recipe roastBeef = new Recipe()
{
    Name = "Roast beef",
  Id=2,
    Description = "Roast beef is a classic British Sunday dinner, typically served with roast potatoes, vegetables, and gravy.",
    recipe = "- Preheat oven to 350°F.\n- Rub a beef roast with salt, pepper, and garlic powder.\n- Roast in the oven for 20 minutes per pound, until cooked to desired doneness.\n- Rest for 10-15 minutes before slicing and serving with roasted potatoes, vegetables, and gravy."
};

Recipe bangersAndMash = new Recipe()
{
    Name = "Bangers and mash",
  Id=3,
    Description = "A simple yet delicious dish of sausages and mashed potatoes, often served with onion gravy.",
    recipe = "- Boil peeled potatoes until tender, then mash with butter, milk, salt, and pepper.\n- Grill or pan-fry sausages until browned and cooked through.\n- Serve sausages on a bed of mashed potatoes and top with onion gravy."
};
Recipe spaghettiCarbonara = new Recipe()
{
    Name = "Spaghetti carbonara",
  Id=4,
    Description = "A classic Italian pasta dish made with spaghetti, pancetta or bacon, eggs, and cheese.",
    recipe = "- Cook spaghetti in salted water until al dente.\n- Cook diced pancetta or bacon until crispy, then remove from pan.\n- In a bowl, beat together eggs, grated Parmesan cheese, salt, and pepper.\n- Add cooked spaghetti to the pan with pancetta or bacon, and toss until coated with the rendered fat.\n- Remove pan from heat and add the egg mixture, stirring constantly until the eggs thicken and create a creamy sauce.\n- Serve immediately with additional Parmesan cheese."
};

Recipe padThai = new Recipe()
{
    Name = "Pad Thai",
  Id=5,
    Description = "A popular Thai stir-fried noodle dish made with shrimp, tofu, bean sprouts, and peanuts.",
    recipe = "- Soak rice noodles in cold water for 30 minutes, then drain.\n- Heat oil in a wok or large skillet, then add minced garlic and shrimp.\n- Add diced tofu, chopped green onions, and beaten eggs, stirring until the eggs are cooked.\n- Add drained noodles, fish sauce, sugar, and chili powder, and stir until combined.\n- Add bean sprouts and peanuts, and stir until the sprouts are wilted.\n- Serve hot with lime wedges."
};

Recipe chickenParmesan = new Recipe()
{
    Name = "Chicken Parmesan",
  Id=6,
    Description = "An Italian-American classic, chicken parmesan is breaded and fried chicken cutlets topped with tomato sauce and melted mozzarella cheese.",
    recipe = "- Season chicken cutlets with salt and pepper.\n- Coat cutlets in flour, dip in beaten egg, and coat in seasoned breadcrumbs.\n- Fry cutlets in oil until browned and cooked through.\n- Top each cutlet with tomato sauce and shredded mozzarella cheese.\n- Bake in the oven until the cheese is melted and bubbly.\n- Serve with spaghetti and additional tomato sauce."
};

Recipe beefStroganoff = new Recipe()
{
    Name = "Beef Stroganoff",
  Id=7,
    Description = "A Russian dish made with sautéed beef strips in a sour cream sauce.",
    recipe = "- Cut beef into thin strips and season with salt and pepper.\n- Sauté the beef in butter until browned, then remove from pan.\n- In the same pan, sauté diced onions and sliced mushrooms until softened.\n- Add beef broth, Dijon mustard, and Worcestershire sauce, and simmer for 5 minutes.\n- Stir in sour cream and cooked beef, and heat through.\n- Serve with egg noodles or rice."
};

Recipe shepherdPie = new Recipe()
{
    Name = "Shepherd's pie",
  Id=8,
    Description = "A traditional British dish consisting of ground beef or lamb cooked in gravy and topped with mashed potatoes.",
    recipe ="Brown ground beef or lamb in a large skillet.\n- Add diced carrots, onions, and garlic, and sauté until softened.\n- Sprinkle flour over the mixture and stir to combine.\n- Add beef broth, Worcestershire sauce, and thyme, and simmer until the mixture thickens.\n- Pour the meat mixture into a baking dish and top with mashed potatoes.\n- Bake in the oven at 375°F for 30 minutes, until the potatoesare golden brown and crispy on top.\n- Serve hot."
};
Recipe sushi = new Recipe()
{
Id=9,
Name = "Sushi",
Description = "A Japanese dish made with seasoned sushi rice and various fillings, typically wrapped in seaweed sheets.",
recipe = "- Cook sushi rice according to package instructions, then season with rice vinegar, sugar, and salt.\n- Prepare fillings such as raw fish, avocado, cucumber, or cooked shrimp.\n- Lay a sheet of seaweed on a sushi mat or piece of plastic wrap.\n- Spread a layer of rice on the seaweed, leaving a small border at the top.\n- Add fillings in a line across the middle of the rice.\n- Use the mat or plastic wrap to roll the sushi tightly, pressing down to seal the edges.\n- Slice the sushi into pieces and serve with soy sauce, wasabi, and pickled ginger."
};

Recipe chiliConCarne = new Recipe()
{
Id=10,
Name = "Chili con carne",
Description = "A spicy Tex-Mex stew made with ground beef, chili peppers, and beans.",
recipe = "- Brown ground beef in a large pot or Dutch oven.\n- Add diced onions and minced garlic, and sauté until softened.\n- Add diced tomatoes, tomato paste, beef broth, chili powder, cumin, and oregano, and bring to a simmer.\n- Add drained and rinsed kidney beans and simmer for 20-30 minutes.\n- Serve hot with cornbread or tortilla chips."
};

Recipe roastedChicken = new Recipe()
{
Id=11,
Name = "Roasted chicken",
Description = "A classic American dish of oven-roasted chicken seasoned with herbs and spices.",
recipe = "- Preheat the oven to 425°F.\n- Rinse and pat dry a whole chicken.\n- Rub the chicken with olive oil and season with salt, pepper, garlic powder, and dried thyme.\n- Stuff the chicken cavity with lemon wedges and fresh herbs like rosemary or thyme.\n- Place the chicken in a roasting pan and bake for 1 hour, or until the internal temperature reaches 165°F.\n- Let the chicken rest for 10-15 minutes before carving and serving."
};

Recipe lasagna = new Recipe()
{
Id=12,
Name = "Lasagna",
Description = "An Italian baked pasta dish made with layers of lasagna noodles, tomato sauce, ground meat, and cheese.",
recipe = "- Cook lasagna noodles in salted water until al dente, then drain.\n- Brown ground beef and Italian sausage in a large skillet.\n- Add diced onions and minced garlic, and sauté until softened.\n- Add tomato sauce, diced tomatoes, and Italian seasoning, and simmer for 10 minutes.\n- In a separate bowl, mix together ricotta cheese, grated Parmesan cheese, and beaten eggs.\n- Preheat the oven to 375°F and assemble the lasagna in a large baking dish, layering noodles, meat sauce, and cheese mixture.\n- Top with shredded mozzarella cheese.\n- Bake in the oven for 30-40 minutes, until the cheese is melted and bubbly.\n- Let the lasagna rest for 10-15 minutes before serving."
};







    return new List<Recipe> { fishAndChips,roastBeef,bangersAndMash,spaghettiCarbonara,padThai,chickenParmesan,beefStroganoff,shepherdPie,lasagna,sushi,chiliConCarne,roastedChicken };
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

