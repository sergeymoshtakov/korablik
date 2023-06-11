using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int rectangleHeight = 50;
            int blueRectangleY = this.ClientSize.Height - rectangleHeight;

            Brush blueBrush = Brushes.Blue;
            g.FillRectangle(blueBrush, 0, blueRectangleY, this.ClientSize.Width, rectangleHeight);

            int roundSize = 150;
            int signX = (this.ClientSize.Width - roundSize) / 2 - 100;
            int signY = (this.ClientSize.Height - roundSize) / 2 - 10;
            Rectangle roundRect = new Rectangle(signX, signY, roundSize, roundSize);

            Brush yellowBrush = Brushes.Yellow;
            g.FillEllipse(yellowBrush, roundRect);

            int triangleSize = 100;
            int triangleX = (this.ClientSize.Width - triangleSize) / 2 + 100;
            int triangleY = (this.ClientSize.Height - triangleSize) / 2 - 25;

            Point[] trianglePoints = {
                new Point(triangleX + triangleSize / 2, triangleY + triangleSize),
                new Point(triangleX + triangleSize, triangleY + triangleSize / 2),
                new Point(triangleX + triangleSize / 2, triangleY)
            };

            Brush whiteBrush = Brushes.White;
            Pen pen = new Pen(Color.Black, 2f);
            g.DrawPolygon(pen, trianglePoints);
            g.FillPolygon(whiteBrush, trianglePoints);

            int sheepSize = 60;
            int sheepX = (this.ClientSize.Width - sheepSize) / 2 + 100;
            int sheepY = (this.ClientSize.Height - sheepSize) / 2 + 36;

            Point[] sheepPoints = {
                new Point(sheepX, sheepY + sheepSize),
                new Point(sheepX + sheepSize, sheepY + sheepSize),
                new Point(sheepX + sheepSize + 50, sheepY),
                new Point(sheepX + sheepSize/2 + 30, sheepY),
                new Point(sheepX + sheepSize/2 + 30, sheepY + 20),
                new Point(sheepX + sheepSize/2 - 30, sheepY + 20),
                new Point(sheepX + sheepSize/2 - 30, sheepY),
                new Point(sheepX - 50, sheepY)
            };

            Brush brownBrush = Brushes.Brown;
            g.DrawPolygon(pen, sheepPoints);
            g.FillPolygon(brownBrush, sheepPoints);
        }
    }
}
