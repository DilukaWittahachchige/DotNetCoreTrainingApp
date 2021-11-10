#region Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace BLL.DataStructures
{
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


        public void LoadAgeDict()
        {

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("John", 33);
            ages.Add("Mary", 22);
            ages.Add("Richard", 15);
            Console.WriteLine("John is {0} years old",ages["John"]);

            //iterate dictionay 
            foreach (KeyValuePair<string,int> item in ages)
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
    }
}