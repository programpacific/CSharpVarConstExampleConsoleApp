using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVarConstExampleConsoleApp
{
    public class Food
    {

        public string Person;
        public string MainCourse;
        public string SideCourse;


        public Food(string person, string mainCourse, string sideCourse)
        { 
        Person = person;
        MainCourse = mainCourse;
        SideCourse = sideCourse;
        }
        public Food(string mainCourse) : this(mainCourse, "Tacos", "Fudge")
        {

        }
        public Food(string person, string favFood) : this(person, favFood, "Cheesecake")
        {

        }

        
        // Condensed code by using optional paramenters!
        //public Food(string name, string food = "Steak", string desert = "Guinness")
        //{
        //    Name = name;
        //    FavoriteFood = food;
        //    FavoriteDesert = desert;
        //}


    }
}
