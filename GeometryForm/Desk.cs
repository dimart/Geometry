using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libgeom;

namespace GeometryForm
{
    public partial class Desk : Form
    {
        private Graphics canvasGraphics;
        private Triangle triangle;
        private Point[] vertices = new Point[4];
        private Rectangle vertex = new Rectangle();
        private Pen whitePen = new Pen(Color.White, 2);
        private int vertexCount = 0;

        public Desk()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Desk_Load(Object sender, EventArgs e)
        {
            canvasGraphics = canvas.CreateGraphics();
            canvasGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void Desk_FormClosed(object sender, FormClosedEventArgs e)
        {
            canvasGraphics.Dispose();
        }

        private void Desk_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    debugCheckBox.Visible = !debugCheckBox.Visible;
                    break;
            }
        }

        private void debugCheckBox_Click(object sender, EventArgs e)
        {
           
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("On paint from  "  + sender);
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            vertexCount++;
            vertex.Width  = 2;
            vertex.Height = 2;
            switch (vertexCount)
            {
                case 1:
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            vertex.X = e.X;
                            vertex.Y = e.Y;
                            vertices[0] = new Point(e.X, e.Y);
                            canvasGraphics.DrawEllipse(System.Drawing.Pens.Black, vertex);
                            break;
                        default:
                            return;
                    }
                    break;

                case 2:
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            vertex.X = e.X;
                            vertex.Y = e.Y;
                            vertices[1] = new Point(e.X, e.Y);
                            canvasGraphics.DrawEllipse(System.Drawing.Pens.Black, vertex);
                            canvasGraphics.DrawLine(whitePen, vertices[0], vertices[1]);
                            break;
                        default:
                            return;
                    }
                    break;

                case 3:
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            vertex.X = e.X;
                            vertex.Y = e.Y;
                            vertices[2] = new Point(e.X, e.Y);
                            canvasGraphics.DrawEllipse(System.Drawing.Pens.Black, vertex);
                            canvasGraphics.DrawLine(whitePen, vertices[0], vertices[1]);
                            canvasGraphics.DrawLine(whitePen, vertices[1], vertices[2]);
                            canvasGraphics.DrawLine(whitePen, vertices[2], vertices[0]);
                            triangle = new Triangle(vertices[0].X, vertices[0].Y, vertices[1].X, vertices[1].Y, vertices[2].X, vertices[2].Y);
                            if (triangle.IsEquilateral()) eqCheck.Visible = true;
                            if (triangle.IsRectangular()) recCheck.Visible = true;
                            break;
                        default:
                            return;
                    }
                    break;

                case 4:
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            vertex.X = e.X;
                            vertex.Y = e.Y;
                            vertices[3] = new Point(e.X, e.Y);
                            canvasGraphics.DrawEllipse(System.Drawing.Pens.Black, vertex);
                            if (triangle.IsEquilateral()) eqCheck.Visible = true;
                            if (triangle.IsRectangular()) recCheck.Visible = true;
                            if (triangle.PointInTriangle(vertex.X, vertex.Y)) pointCheck.Visible = true;
                            break;
                        default:
                            return;
                    }
                    break;

                default:
                    this.Invalidate();
                    vertexCount = 0;
                    firstSideTB.Text = "";
                    secondSideTB.Text = "";
                    thirdSideTB.Text = "";
                    eqCheck.Visible = false;
                    recCheck.Visible = false;
                    pointCheck.Visible = false;
                    return;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            switch (vertexCount)
            {
                case 0: return;
                case 1:
                    firstSideTB.Text = Convert.ToString((int)Math.Sqrt(Math.Pow(e.X - vertices[0].X, 2) + Math.Pow(e.Y - vertices[0].Y, 2)));
                    return;
                case 2:
                    secondSideTB.Text = Convert.ToString((int)Math.Sqrt(Math.Pow(e.X - vertices[1].X, 2) + Math.Pow(e.Y - vertices[1].Y, 2)));
                    thirdSideTB.Text = Convert.ToString((int)Math.Sqrt(Math.Pow(e.X - vertices[0].X, 2) + Math.Pow(e.Y - vertices[0].Y, 2)));
                    return;
                default: return;
            }
        }

        private void switchPB_Click(object sender, EventArgs e)
        {
            //for smooth switch
            if (!switchPB1.Visible)
            {
                switchPB1.Visible = !switchPB1.Visible;
                switchPB0.Visible = !switchPB0.Visible;
            }
            else
            {
                switchPB0.Visible = !switchPB0.Visible;
                switchPB1.Visible = !switchPB1.Visible;
            }
            //

            firstSideTB.Enabled = !firstSideTB.Enabled;
            secondSideTB.Enabled = !secondSideTB.Enabled;
            thirdSideTB.Enabled = !thirdSideTB.Enabled;
            firstSideTB.Text = "";
            secondSideTB.Text = "";
            thirdSideTB.Text = "";
            canvas.Enabled = !canvas.Enabled;
            calculateButton.Visible = !calculateButton.Visible;
            pointCheck.Visible = !pointCheck.Visible;
            pointInsideLabel.Visible = !pointInsideLabel.Visible;
            eqCheck.Visible = false;
            recCheck.Visible = false;
            pointCheck.Visible = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (firstSideTB.Text == "" || secondSideTB.Text == "" || thirdSideTB.Text == "") return;
            int A = Convert.ToInt32(firstSideTB.Text);
            int B = Convert.ToInt32(secondSideTB.Text);
            int C = Convert.ToInt32(thirdSideTB.Text);
            if (A == 0 || B == 0 || C == 0)
            {
                MessageBox.Show(Strings.ZeroLenghtError); return; 
            }
            triangle = new Triangle(A, B, C);
            if (triangle.IsEquilateral()) eqCheck.Visible = true;
            if (triangle.IsRectangular()) recCheck.Visible = true;
        }

        private void anySideTB_TextChanged(object sender, EventArgs e)
        {
            eqCheck.Visible = false;
            recCheck.Visible = false;
        }
    }
}
