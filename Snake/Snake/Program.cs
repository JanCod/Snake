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
            

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
            rightLine.Draw();
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '*');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
            downLine.Draw();           


            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Console.ReadLine();
        }
    }
}
