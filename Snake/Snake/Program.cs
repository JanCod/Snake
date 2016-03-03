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
            
            //рамочка
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
            leftLine.Draw();
            rightLine.Draw();
            upLine.Draw();
            downLine.Draw();

            //точки
            Point p = new Point(2, 2, '?');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
