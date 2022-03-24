using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions1;

namespace Extensions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  name = "aysel";
            
            string [] array = { "Hi", "Hello", "Good"};
            string words = name + " " + array;


            

            Console.WriteLine(name.CapitaliseString());
            Console.WriteLine(name.ReverseMethod());

            Console.WriteLine(name.IndexReturn(2));
            foreach (var item in array.Append(words))
            {
                Console.WriteLine(item);
            }
            
            


        }
    } 
}
