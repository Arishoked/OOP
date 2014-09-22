using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP
{
    class Triangle : Shape
    {
        public override void Draw(Graphics graphics, Point point, Point point1)
        {

             Point point2;
             point2 = new Point();
             point2.X = point.X - 2 * (point.X - point1.X);
             point2.Y = point.Y;
             graphics.DrawLine(pen, point,point1);
             graphics.DrawLine(pen, point1, point2);
             graphics.DrawLine(pen, point2, point);

        }
    }
}
