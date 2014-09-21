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
            shapes.Add(new Triangle());
            shapes.Add(new Line());   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black);
            graphics = pictureBox1.CreateGraphics();
            shapes[0].point.X = 10;
            shapes[0].point.Y = 10;
            shapes[0].point1.X = 60;
            shapes[0].point1.Y = 60;
            shapes[0].pen = new Pen(Color.Black);
           
            shapes[1].point.X = 10;
            shapes[1].point.Y = 90;
            shapes[1].point1.X = 70;
            shapes[1].point1.Y = 90;
            shapes[1].point2.X = 35;
            shapes[1].point2.Y = 150;
            shapes[1].pen = new Pen(Color.Red);
           
            shapes[2].point.X = 80;
            shapes[2].point.Y = 10;
            shapes[2].point1.X = 130;
            shapes[2].point1.Y = 60;
            shapes[2].pen = new Pen(Color.Blue);
            foreach (Shape s in shapes)
            {

                s.Draw(graphics);
            }  
        }
    }
}
