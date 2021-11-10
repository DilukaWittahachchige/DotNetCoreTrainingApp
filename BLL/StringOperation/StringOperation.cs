using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StringOperation
{
    public class StringOperation
    {

        public static void concat1(String s1)
        {

            // taking a string which
            // is to be Concatenate
            String st = "forGeeks";

            // using String.Concat method
            // you can also replace it with
            // s1 = s1 + "forgeeks";

            //Assign to new memory location
            String st1 = String.Concat(s1, st);

            s1 = String.Concat(s1, st);
       
            //New string after concat two strings
            Console.WriteLine("new string after concat :"+st1);

        }

        // Concatenates to StringBuilder
        public static void concat2(StringBuilder s2)
        {

            // using Append method
            // of StringBuilder class
            s2.Append("forGeeks");
        }

        public void LoadStringData()
        {
            String s1 = "Geeks";
            concat1(s1); // s1 is not changed
            Console.WriteLine("Using String Class: " + s1);

            StringBuilder s2 = new StringBuilder("Geeks");
            concat2(s2); // s2 is changed
            Console.WriteLine("Using StringBuilder Class: " + s2);
        }
    }
}
