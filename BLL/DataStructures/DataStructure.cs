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
        starts at index 0.*/
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
    }
}