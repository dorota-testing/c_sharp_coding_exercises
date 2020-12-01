using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word) 
        {
            string first = word.Substring(0, 1);
            string rest = word.Substring(1, (word.Length-1));
            string capitalised = first.ToUpper() + rest;
            return capitalised;
        }

        public static String GenerateInitials(String firstName, String lastName) 
        {
            string initials = firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(0,1).ToUpper();
            return initials;
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            double  vat = (vatRate / 100) * originalPrice;
            vat = Math.Round(vat, 2); 
            double vatPrice = originalPrice + vat;
            return vatPrice;
        }

        public static String Reverse(String sentence) 
        {
            char[] reversed = (sentence.ToCharArray());
            Array.Reverse( reversed );
            string str = new string(reversed);
            return str;
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            int count = 0; 
            foreach (var user in users) {
                if(user.Type == "Linux"){
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
