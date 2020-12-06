﻿using PRE.Model.Model.Util;
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


        public User User { get; set; }
        public Category Category { get; set; }
        public Ingredient Ingredients { get; set; }
        public Comment Comments { get; set; }


        //Create builders to generate Recipes
        public Recipe()
        {
        }

        public Recipe(int idRecipe, string name, string description, TimeSpan duration, Difficulty difficulty, Rating rating, bool isValidated)
        {
            IdRecipe = idRecipe;
            Name = name;
            Description = description;
            Duration = duration;
            Difficulty = difficulty;
            Rating = rating;
            IsValidated = isValidated;
        }
    }
}

