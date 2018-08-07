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
    public class Program
    {

        static void Main(string[] args)
        {

            const string exampleOne = "const";
            var shortDescriptionOfVar = "\"var\" variables";
            Food MyFavorite = new Food("Stephen", "Steak", "Guinness");
            Food TimFavorite = new Food("Tim's", "Cheese Burgers");
            Food ClaireFavorite = new Food("Claire's");



            Console.WriteLine("This is a short example of the use of various variable types and chained constructors!\n" +
                "For example we'll be using, " + exampleOne + " and " + shortDescriptionOfVar + "!\n" +
                "Lastly is an example of two constructors chained together!\n\nChaining constructors togethere we are able to produce multiple results!" +
                "\n\nHere are a few examples!\n");


            // I feel confident that I now have a better understanding of constructor chaining, glad I spent a little more time with them!
            // Have a great day everyone!

            Console.WriteLine("My Favorite Food: {0}", MyFavorite.MainCourse);
            Console.Write("My Favorite Desert: {0}\n\n", MyFavorite.SideCourse);
            
            Console.WriteLine("{0} Favorite Foods", TimFavorite.Person );
            Console.WriteLine("Favorite Food: {0}", TimFavorite.MainCourse);
            Console.WriteLine("Favorite Desert: {0}\n\n", TimFavorite.SideCourse);
            
            Console.WriteLine("{0} Favorite Foods", ClaireFavorite.Person );
            Console.WriteLine("Favorite Food: {0}", ClaireFavorite.MainCourse);
            Console.WriteLine("Favorite Desert: {0}\n\n", ClaireFavorite.SideCourse);
            
            Console.WriteLine("Thank you for demoing my application!\n" +
                "Press enter to exit!");
            Console.ReadLine();
        }
    }
}
