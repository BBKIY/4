using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = 52;
            int perLineCount = 3;
            int rowFilled = pictureCount / perLineCount;
            int overFlowCount = pictureCount % perLineCount;
            Console.WriteLine("Полностью заполненных рядов " + rowFilled);
            Console.WriteLine("Картинок сверх меры " + overFlowCount);
        }
    }
}
