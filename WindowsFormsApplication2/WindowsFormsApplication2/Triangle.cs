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
        public override void Draw(Graphics graphics) 
        {
            
             graphics.DrawLine(pen, point,point1);
             graphics.DrawLine(pen, point1, point2);
             graphics.DrawLine(pen, point2, point);

        }
    }
}
