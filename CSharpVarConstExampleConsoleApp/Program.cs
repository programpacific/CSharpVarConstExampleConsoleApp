using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVarConstExampleConsoleApp

   //    EXERCISE:
  //1. Create a const variable
 //2. Create a variable using the keyword "var".
//3. Chain two constructors together.


{
    class Program
    {

        static void Main(string[] args)
        {
            const string exampleOne = "const";
            var shortDescriptionOfVar = "\"var\" variables";
            Food MyFavorite = new Food("Stephen");

            Console.WriteLine("Hi! my name is " + MyFavorite.Name + ". This is a short example of the use of various variable types.\n" +
                "For example we'll be using, " + exampleOne + " and " + shortDescriptionOfVar + "!\n" +
                "Lastly is an example of two constructors chained together!\n\n");
            Console.WriteLine("My Favorite Food: {0}", MyFavorite.FavoriteFood);
            Console.Write("My Favorite Desert: {0}\n\n", MyFavorite.FavoriteDesert);
            Console.WriteLine("Thank you for demoing my application!\n" +
                "Press enter to exit!");
            Console.ReadLine();
        }
    }
}
