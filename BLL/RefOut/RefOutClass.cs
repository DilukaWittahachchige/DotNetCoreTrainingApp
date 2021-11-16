using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RefOut
{
    public class RefOutClass
    {

        public void ShowData()
        {
            // Assign string value
            string str = "Geek";

            int b; //b= 0

            // Pass as a reference parameter
            //SetValue(str);
            SetValue(ref str);

            //Can't use Async programming out/ref -> need to use tuples 
            //var data = SetValueTwo(ref str);

            //Console.WriteLine(data);

            // Display the given string
            Console.WriteLine(str);

            var data = update(out b);

            Console.WriteLine(data+ " : "+b);

            //ref -> need to assign value | out -> no need to assign value 
        }

        #region Ref
        static void SetValue(ref string str1)
        {

            // Check parameter value
            if (str1 == "Geek")
            {
                Console.WriteLine("Hello!!Geek");
            }

            // Assign the new value
            // of the parameter
            str1 = "GeeksforGeeks";
        }

        static string SetValueTwo(ref string str1)
        {

            // Check parameter value
            if (str1 == "Geek")
            {
                Console.WriteLine("Hello!!Geek");
            }

            // Assign the new value
            // of the parameter
            str1 = "GeeksforGeeks";

            return "test";
        }

        #endregion

        #region Out
        public static string update(out int a)
        {
            a = 10;

            return "value";
        }
        #endregion

    }
}
