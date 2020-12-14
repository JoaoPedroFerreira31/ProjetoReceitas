using PRE.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Model.Model
{
    public class Recipe
    {
        public int IdRecipe { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public Difficulty Difficulty { get; set; } //Enum
        public Rating Rating { get; set; } //Enum                
        public bool IsValidated { get; set; }


        public int IdUser { get; set; }
        public Category Category { get; set; }
        public Ingredient Ingredients { get; set; }
        public Comment Comments { get; set; }

        public override string ToString()
        {
            return $"{IdRecipe}, {Name}, {Description}, {Duration}, {Difficulty}, {Rating}, {IsValidated}, {Category}";
        }


        //Create builders to generate Recipes
        public Recipe()
        {
        }

        public Recipe(int idRecipe, string name, string description, TimeSpan duration, Difficulty difficulty, Rating rating, Category category, bool isValidated)
        {
            IdRecipe = idRecipe;
            Name = name;
            Description = description;
            Duration = duration;
            Difficulty = difficulty;
            Rating = rating;
            Category = category;
            IsValidated = isValidated;
        }

        public Recipe(string name, string description, TimeSpan duration, Difficulty difficulty, Category category, int idUser)
        {
            Name = name;
            Description = description;
            Duration = duration;
            Difficulty = difficulty;
            Category = category;
            IdUser = idUser;
        }
    }
}

