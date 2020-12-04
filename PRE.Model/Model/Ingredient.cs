using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Model.Model
{
    public class Ingredient
    {
        public int IdIngredient { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }

        public override string ToString()
        {
            return $"ID: {IdIngredient}, Name: {Name}";
        }

        public Ingredient()
        {
        }
    
        public Ingredient(string name)
        {
            Name = name;
        }

        public Ingredient(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public Ingredient(string name, string unit)
        {
            Name = name;
            Unit = unit;
        }
    }    
}
