using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int row = 3;

            int numberOfRows = pictures / row;
            int beyondMeasure = pictures - (numberOfRows * row);

            Console.WriteLine(numberOfRows);
            Console.WriteLine(beyondMeasure);
            Console.ReadKey();
        }
    }
}
