using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        static Graphics graphics;
        static Bitmap bitmap;
        static Pen pen;
        List<Shape> shapes;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shapes = new List<Shape>();
            shapes.Add(new Rectangle());
            shapes.Add(new Ellipse());
            shapes.Add(new Triangle());
            shapes.Add(new Line());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point, point1;
            point = new Point();
            point1 = new Point();

            pen = new Pen(Color.Black);
            graphics = pictureBox1.CreateGraphics();
            point.X = 10;
            point.Y = 10;
            point1.X = 60;
            point1.Y = 60;
            shapes[0].pen = new Pen(Color.Black);
            shapes[0].Draw(graphics, point, point1);
            point.X = 70;
            point.Y = 70;
            point1.X = 70;
            point1.Y = 70;          
            shapes[1].pen = new Pen(Color.Green);
            shapes[1].Draw(graphics, point, point1);
            
            point.X = 10;
            point.Y = 90;
            point1.X = 35;
            point1.Y = 150;
            shapes[2].pen = new Pen(Color.Red);
            shapes[2].Draw(graphics, point, point1);

            point.X = 80;
            point.Y = 10;
            point1.X = 130;
            point1.Y = 60;
            shapes[3].pen = new Pen(Color.Blue);
            shapes[3].Draw(graphics, point, point1);
        }
    }
}
