using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        enum Apple
        {
           Jonathan, GoldenDel, RedDel, Winesap,
           Cortland, McIntosh
        };

        static void Main(string[] args)
        {
            string[] color = {  "Red",
                                "Yellow",
                                "Red",
                                "Red",
                                "Red",
                                "Reddish Green"
                              };
            
            Apple i;
            for(i = Apple.Jonathan;i<Apple.McIntosh;i++)
            {
                Console.WriteLine(i + "has value " + (int)i);
                
            }
            Console.WriteLine();
            // Use an enumeration to index an array.
            for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
                Console.WriteLine("Color of " + i + " is " + color[(int)i]);
            Console.Read();


        }
    }
}
