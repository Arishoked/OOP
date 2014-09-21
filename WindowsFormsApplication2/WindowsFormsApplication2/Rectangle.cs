using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP
{
    class Rectangle : Shape
    {
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, point.X, point.Y, point1.X,point1.Y);
        }
    }
}
