using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
                        
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(4, 10, 7, '#');
            VerticalLine line2 = new VerticalLine(7, 13, 4, '#');
            line.Draw();
            line2.Draw();

            Console.ReadLine();
        }
    }
}
