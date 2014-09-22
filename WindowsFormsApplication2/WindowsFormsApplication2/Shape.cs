using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace OOP
{
    public class Shape
    {
        public Point point, point1,point2;
        public Pen pen;
        public virtual void Draw(Graphics graphics,Point point,Point point1) { }
    }
}
