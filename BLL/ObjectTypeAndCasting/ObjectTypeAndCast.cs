using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ObjectTypeAndCasting
{
    class ObjectTypeAndCast
    {
    }

    class Y { }
    class Z { }

    public static class AsOperatorSample
    {

        // Main method
        public static void Show()
        {

            // creating and initializing object array
            object[] o = new object[5];
            o[0] = new Y();
            o[1] = new Z();
            o[2] = "Hello";
            o[3] = 4759.0;
            o[4] = null;

            for (int q = 0; q < o.Length; ++q)
            {

                // using as operator
                string str1 = o[q] as string;

                Console.Write("{0}:", q);

                // checking for the result
                if (str1 != null)
                {
                    Console.WriteLine("'" + str1 + "'");
                }
                else
                {
                    Console.WriteLine("Is is not a string");
                }
            }
        }
    }




    // taking a class
    public class P { }

    // taking a class
    // derived from P
    public class P1 : P { }

    // taking a class
    public class P2 { }

    // Driver Class
    public static class IsOperatorSample
    {

        // Main Method
    public static void Show()
        {

            //Before cast need to check  int data = (int)number; if number not a int then it throws error

            // creating an instance
            // of class P
            P o1 = new P();

            // creating an instance
            // of class P1
            P1 o2 = new P1();

            // checking whether 'o1'
            // is of type 'P'
            Console.WriteLine(o1 is P);

            // checking whether 'o1' is
            // of type Object class
            // (Base class for all classes)
            Console.WriteLine(o1 is Object);

            // checking whether 'o2'
            // is of type 'P1'
            Console.WriteLine(o2 is P1);

            // checking whether 'o2' is
            // of type Object class
            // (Base class for all classes)
            Console.WriteLine(o2 is Object);

            // checking whether 'o2'
            // is of type 'P'
            // it will return true as P1
            // is derived from P
            Console.WriteLine(o2 is P1);

            // checking whether o1
            // is of type P2
            // it will return false
            Console.WriteLine(o1 is P2);

            // checking whether o2
            // is of type P2
            // it will return false
            Console.WriteLine(o2 is P2);
        }
    }
}
