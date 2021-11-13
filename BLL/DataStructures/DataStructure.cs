#region Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace BLL.DataStructures
{
    #region enum 
    //Perhaps one can say this can be accomplished with variables and integer
    //values too.But I believe Enum is a safer and a programmer's way.readability.
    public enum Direction
    {
        UP, DOWN
    }
    #endregion

    #region class
    /// <summary>
    ///  Implement Data Structures
    /// </summary>
    public class DataStructure
    {
        #region Array
        /*element of the array is accessed through its index.Note that the first element
        starts at index 0. Can manage fix value set*/
        public string[] LoadArrayDataFirst()
        {
            string[] names = new string[] { "John", "Mary", "Richard" };
            return names;

            /*If you have set of values and the number of values will not change during the
             * current process and you have an integer you can use or calculate easily to reference those values, 
             * use an array. You will be rewarded with simpler code that runs faster. */
        }

        /// <summary>
        ///  Return names 
        /// </summary>
        /// <returns> string[]</returns>
        public string[] LoadArrayDataSecond()
        {
            string[] names = new string[3]; // array containing three elements of type string
            names[0] = "John";

            return names;
        }
        #endregion

        #region List
        public void LoadNameList()
        {
            /*A List is dynamic and elements can be added or removed on the fly.When
              creating a List the type of the element it contains must be specified.*/

            //Create list
            List<string> names = new List<string>(); // type = string

            //Add values 
            names.Add("John");
            names.Add("Mary");
            names.Add("Richard");

            //Display data in a list 
            Console.WriteLine("My people are {0}, {1} and {2}", names[0], names[1],
            names[2]);

            //Remove list item
            names.RemoveAt(0);

            Console.WriteLine("My people are {0}, {1}", names[0], names[1]
             );
        }

        #endregion

        #region Dictionnary 

        /*
         You use Dictionary<TKey,TValue> when you need to store values with some unique keys associated to them, 
          and accessing them by that key is convenient for you. */

        /*In Dictionary, the key cannot be null, but value can be. In Dictionary, 
         key must be unique. Duplicate keys are not allowed if you try to use duplicate key then compiler will throw an exception.
        */

        public void LoadAgeDict()
        {

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("John", 33);
            ages.Add("Mary", 22);
            ages.Add("Richard", 15);
            Console.WriteLine("John is {0} years old", ages["John"]);

            //iterate dictionay 
            foreach (KeyValuePair<string, int> item in ages)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            //iterate dictionay values
            foreach (var value in ages.Values)
            {
                Console.WriteLine(value.ToString());
            }

            //iterate dictionay values
            foreach (var value in ages.Keys)
            {
                Console.WriteLine(value.ToString());
            }
        }
        #endregion

        #region Hashtable

        /*
         * It optimizes lookups by computing the hash code of each key and stores
         * it in a different bucket internally and then matches the hash code of the
         * specified key at the time of accessing values.*/

        public void LoadHashtable()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfUSA = (string)cities["USA"]; //cast to string

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            cities.Remove("UK"); // removes UK 
            //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            // cities.Clear(); //removes all elements
        }
        #endregion

        #region Switch

        public void LoadResponse(string rank)
        {
            switch (rank)
            {
                case "eco":
                    Console.WriteLine("Hey!");
                    break;
                case "business":
                    Console.WriteLine("Hello!");
                    break;
                case "premier":
                    Console.WriteLine("Good morning Sir.");
                    break;
                case "king":
                    Console.WriteLine("My Lord.");
                    break;
                default:
                    Console.WriteLine("Ugh");
                    break;
            }
        }



        #endregion

        #region enumimplementation
        public void LoadValue(Direction direction)
        {
            int i = 5;
            ////Check the Enum type
            if (direction == Direction.UP)
            {
                i++;
            }
            else
            {
                i--;
            }

            Console.WriteLine(i);
        }

        #endregion
    }
    #endregion

    #region struct
    /*
     Struct supports many features that are also supported by class. The major
     difference is that the struct is a value type in opposition to the class which is a
     reference type.
     */

    /*struct can be used to hold small data values that do not require inheritance,
        e.g.coordinate points, key-value pairs, and complex data structure.*/

    public struct Coordinate
    {
        public int x;
        public int y;

        //Parameterized Constructor in Struct
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    #endregion
}