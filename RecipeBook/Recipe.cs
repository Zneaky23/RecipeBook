using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeBook //each recipe will have a name, category, prep time, ingredients, and instructions. This class will be used to create recipe objects that can be added to the recipe book.
{

    public enum RecipeCategory //creating an enum for the recipe categories that will be used to categorize the recipes in the recipe book
    {
        Breakfast,
        Lunch,
        Dinner,
        Dessert
    }

    public class Recipe
    {
        public string Name { get; set; } //getting every property of the recipe and setting it to a variable
        public RecipeCategory Category { get; set; }
        public int PrepTime { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }

        public Recipe(string name, RecipeCategory category, int prepTime, //each property of the recipe is set to a variable and then passed into the constructor
                      string ingredients, string instructions)
        {
            Name = name; //setting the variables to the properties of the recipe
            Category = category;
            PrepTime = prepTime;
            Ingredients = ingredients;
            Instructions = instructions;
        }
    }
}