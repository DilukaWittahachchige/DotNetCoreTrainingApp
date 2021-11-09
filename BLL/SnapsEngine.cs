using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //static -  static class is loaded by the .NET runtime when the program
    //that references the class is loaded
    public static class SnapsEngine
    {
        //access type - public -> can access anywhere
        public static string LoadData()
        {
            int a = 1; //int -> variable type | a -> variable name | 1 -> variable value
            string text = "abcdef";
            int b = a * 2; // result of an operation can be assigned to a variable
            int c; // value of c is intiialized at 0

            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3; //Decimals have much higher precision -financial applications
       
            var d = 5.2; // type is infered

            string text2 = text + " jklm"; // this is a string concatenation

            IEnumerable<int> xs = OddSequence(50, 110);

            return $"Final string : {text2} {d} {b} {a} {text}  {flt}, {dbl}, {dcm}";   //string interpolation |This feature is available starting with C# 6.

            ////Similar method for string interpolation
            //string primes;
            //primes = String.Format("Prime numbers less than 10: {0}, {1}, {2}, {3}",
            // 2, 3, 5, 7);
            //Console.WriteLine(primes);
            //// The example displays the following output:
            ////      Prime numbers less than 10: 2, 3, 5, 7

            //-----------------------------------------------------------------------------------------------
            //Types 

            /*The basic types in .NET are:
            byte: integer from 0 to 255
            short / int / long: integer values of different sizes

            float - 7 digits (32 bit) / double 15-16 digits (64 bit): simple / double precision number | Floating binary point types are much faster to work with than decimals.
            For values which are more artefacts of nature which can't 
             really be measured exactly anyway, float/double are more appropriate. For example, scientific data 

            decimal: 28-29 significant digits (128 bit) ,decimal value, suited for acurate computations |. This is usually suitable for any concepts invented by humans:
            financial values are the most obvious example, but there are others too

            char: a character
            string: several characters
            bool: a boolean value(true or false)*/

        }
        //Work with EF need to know | enhance your LINQ query performance.->IEnumerable,IQueryable
        //Neither IEnumerable does not support lazy loading
        //IQueryable<T> support lazy loading themselves. | System.Linq
        //https://www.stechies.com/difference-between-ienumerable-iqueryable/

        //IEnumerable process data from database then load data into memory in client side then do filtering 
        //best utilized for querying data from the in-memory collections of the likes of Lists, Arrays, and so forth.
        //LINQ to XML queries
        //As IEnumerable performs a lot more work than IQuerytable, it is much slower.
        //IEnumerable is preferable mainly for small data manipulations
        //creating an IEnumerable, all rows are pulled into the memory location in the form of objects before the query is run.
        //In these methods, in case ToArray () or ToList () is not called, then the query will be run every time it is used.
        //Use an eager loading IEnumerable when you want to pass an entire list to the client in one go.
        //They can still add linq clauses, but the client does not benefit from deferred execution.

        //----------------------------------------------------------------------------------------------------------------------------------
        //IQueryable process data from database with all filters - suitable for load data from remote databases and services /out-memory collections.
        // - supports lazy loading and can be utilized for paging like scenarios.
        // supports extension methods.
        // LINQ to SQL queries.
        //In comparison to IEnumerable, it does less work and therefore showcases faster performance.
        //IQueryable is useful for performing big-sized data manipulation tasks
        // Iqueryable, the same can be converted to SQL and executed on database servers

        //Use a lazy loading IQueryable when you want to extend deferred querying capabilities to the client,
        // by allowing the client to add their own linq clauses. This defers execution of the entire query until output is required.

        //The main difference existing between “IEnumerable” and “IQueryable” may be related to the location
        //wherein the filter logic is executed

        //Deferred execution and eager evaluation
        //https://stackoverflow.com/questions/2515796/deferred-execution-and-eager-evaluation
        //https://stackoverflow.com/questions/1578778/using-iqueryable-with-linq/1578977

        //foreach also can use 

        public static IEnumerable<int> OddSequence(int start, int end)
        {
            //Exception handling
            if (start < 0 || start > 99)
                throw new ArgumentOutOfRangeException(nameof(start), "start must be between 0 and 99.");
            if (end > 100)
                throw new ArgumentOutOfRangeException(nameof(end), "end must be less than or equal to 100.");
            if (start >= end)
                throw new ArgumentException("start must be less than end.");

            return GetOddSequenceEnumerator();

            //Local function 
            IEnumerable<int> GetOddSequenceEnumerator()
            {
                
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 1)
                        yield return i; //Return final filter IEnumerable<int> base on logic | only IEnumerable
                }
            }
        }

        //public static IEnumerable<Student> GetTeenAgerStudents(this IEnumerable<Student> source)
        //{

        //    foreach (Student std in source)
        //    {
        //        Console.WriteLine("Accessing student {0}", std.StudentName);

        //        if (std.age > 12 && std.age < 20)
        //            yield return std;
        //    }
        //}

    }
}
