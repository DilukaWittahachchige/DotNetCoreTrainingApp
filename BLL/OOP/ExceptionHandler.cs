using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.OOP
{
    public class ExceptionHandler
    {
        public void Say(string what)
        {
            if (what == null)
            {
                //Throw error 
                throw new ArgumentNullException("what", "No value has been provided");
            }
            Console.Write(what);
        }
    }
}
