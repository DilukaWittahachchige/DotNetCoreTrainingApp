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
            Console.WriteLine("new string after concat :" + st1);

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

        #region String formatting
        public void ShowStringFormat()
        {
            String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            // 0x7FFFFFFFFFFFFFFF 9.223372E+018 9,223,372,036,854,775,807.00

            string[] names = { "Adam", "Bridgette", "Carla", "Daniel" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82 };
            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");

            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);
            // Name Hours
            //
            // Adam 40.0
            // Bridgette 6.7
            // Carla 40.4
            // Daniel 82.0
            var dateTimeNow = String.Format("{0:dddd MMMM}", DateTime.Now);
            Console.WriteLine(dateTimeNow);
            // Monday April
        }
        #endregion
    }
}
