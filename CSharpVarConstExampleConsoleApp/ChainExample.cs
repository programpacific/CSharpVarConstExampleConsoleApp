using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVarConstExampleConsoleApp
{
    public class Food
    {
        public string Name { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteDesert { get; set; }


        // Condensed code by using optional paramenters!
        public Food(string name, string food = "Steak", string desert = "Guinness")
        {
            Name = name;
            FavoriteFood = food;
            FavoriteDesert = desert;
        }

    }
}
