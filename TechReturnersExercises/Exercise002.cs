using System;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester( Person person ) 
        {
            // Add your code here!
            string city = person.City;
            if (city == "Manchester") {
                return true;
            } else {
                return false;
            }
        }

        public static bool CanWatchFilm(Person person, int ageLimit) 
        {
            // Add your code here!
            int age = person.Age;
            if (age >= ageLimit) {
                return true;
            } else {
                return false;
            }
        }
    }
}
