using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.tuples
{
    public class TupleExample
    {
        public static Tuple<string, string, int> GetTupleMethod()
        {
            // Create a 3-tuple and return it  
            var author = new Tuple<string, string, int>(
            "Mahesh Chand", "Programming C#", 2002);
            return author;
        }
    }
}