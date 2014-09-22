﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP
{
    class Ellipse : Shape
    {
        public override void Draw(Graphics graphics, Point point, Point point1)
        {
            graphics.DrawEllipse(pen, point.X, point.Y, point1.X, point1.Y);
        }
    }
}
