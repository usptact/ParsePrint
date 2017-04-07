using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();
            node.key = "X";
            node.value = "1";

            Console.WriteLine("Key = {0}", node.key);
            Console.WriteLine("Value = {0}", node.value);

            Console.ReadLine();

        }
    }
}
