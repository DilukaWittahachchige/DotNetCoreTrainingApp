using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Loops
{
    public static class LoopSample
    {

        #region While loop 

        /*The while loop repeats a block of code as long as the condition that is
        specified is valid. */
        public static void LoadWhileLoop()
        {
            int nbChocolateEaten = 0;
            while (nbChocolateEaten < 6)
            {
                Console.WriteLine("I'm hungry let's eat some chocolate");
                nbChocolateEaten++;
            }
            Console.WriteLine("I'm full");
        }

        #endregion

        #region Do WhileLoop
        /*The do while is similar the the while expect the the block of code will at
            least be executed once.
       */
        public static void LoadDoWhileLoop()
        {
            int nbChocolateEaten = 0;
            do
            {
                Console.WriteLine("Let's eat some chocolate");
                nbChocolateEaten++;
            } while (nbChocolateEaten < 0);
            Console.WriteLine("I'm full");
        }
        #endregion

        #region Do For Loop
        /*The do while is similar the the while expect the the block of code will at
            least be executed once.
       */
        public static void LoadForLoop()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Eating chocolate {0} on 5", i);
            }
        }
        #endregion

        #region ForEach Loop
        /*The do while is similar the the while expect the the block of code will at
            least be executed once.
       */
        public static void LoadForEachLoop()
        {
            string[] names = new string[] { "John", "Mary", "Richard" };
            foreach (string name in names)
            {
                Console.WriteLine("Hello {0}", name);
            }
        }
        #endregion

    }
}
