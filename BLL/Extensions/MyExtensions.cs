using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Extensions
{
    public static class MyExtensions
    {
        /*
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
         * Extension methods enable you to "add" methods to existing types without creating a new derived type, 
             recompiling, or otherwise modifying the original typ
            Extension methods are static methods
         
        this keyword refers to the current instance of the class and is also used as a modifier of the first
        parameter of an extension method
         */

        // System.String class extension 
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
            StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
