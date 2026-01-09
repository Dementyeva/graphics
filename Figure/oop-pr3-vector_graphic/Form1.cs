using Ffigures;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ffigures.Figure;

namespace Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Initialize();
        }

        private void Initialize()
        {
            Figure.device = g;
            Figure.PenWidth = 2;

            Figure.maxp = new Point(this.Width, this.Height);
            
            Figure.BackgroundColor = this.BackColor;
        }

        private Graphics g;

        public List<Figure> figures = new List<Figure>();
      
        private Figure selectedFigure = null;

        private Random rand = new Random();
        private Size minSize = new Size(50, 100);
        private Size maxSize = new Size(300, 300);

        private bool move = false;
        private Point Point1 = new Point(-1, -1);

        const int step = 10;
        

        public float GetTotalSquare()
        {
            float totalSquare = 0;

            foreach (var figure in figures)
            {
                totalSquare += figure.GetSquare();
            }

            return totalSquare;
        }
        public void ShowAll()
        {
            foreach (var figure in figures)
            {
                figure.Show();
            }
        }

        public void MoveAll(int x, int y)
        {
            foreach (Figure figure in figures)
            {
                figure.move(x, y);
            }
        }

        private void panelBorderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Panel)sender).BackColor = colorDialog1.Color;
            }
        }
        private Figure NewFigure(string figureType, Point indent, Size size)
        {
            switch (figureType.Trim().ToLowerInvariant()) 
            {
                case "pyramid":
                    return new Pyramid(indent, size);
                case "sphere":
                    return new Sphere(indent, size);
                case "cylinder":
                    return new Cylinder(indent, size);
                case "rectangle":
                    return new Ffigures.Figure.Rectangle(indent, size);
                case "trapezoid":
                    return new Trapezoid(indent, size, 5);
                case "rhombus":
                    return new Rhombus(indent, size);
                case "circle":
                    return new Circle(indent, size);
                case "ellipse":
                    return new Ellipse(indent, size);
                case "rectangular triangle":
                    return new Rectangular(indent, size);
                case "equilateral triangle":
                    return new Equilateral(indent, size);
                default:
                    throw new ArgumentException($"тип фігури? '{figureType}'");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var figure in figures.ToArray().Reverse())
            {
                bool belongToFigure = (e.X >= figure.p.X) && (e.X <= figure.p.X + figure.size.Width) && (e.Y >= figure.p.Y) && (e.Y <= figure.p.Y + figure.size.Height);

                if (belongToFigure)
                {
                    selectedFigure = figure;

                    BColor.BackColor = figure.borColor;
                    panelBrushColor.BackColor = figure.brushColor;

                    Point1 = new Point(e.X, e.Y);
                    move = true;

                    break;
                }
            }

         
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                selectedFigure.move(e.X - Point1.X, e.Y - Point1.Y);
                Point1 = new Point(e.X, e.Y);

                ShowAll();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            selectedFigure = null;
            move = false;
            Point1 = new Point(-1, -1);

         
        }


        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveAll(0, -step);
            ShowAll();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveAll(0, step);
            ShowAll();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            MoveAll(-step, 0);
            ShowAll();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            MoveAll(step, 0);
            ShowAll();
        }


        private void btnCircle_Click(object sender, EventArgs e)
        {
            /* Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
             int diameter = rand.Next(minSize.Width, maxSize.Width + 1);

             Circle circle = new Circle(indent, new Size(diameter, diameter));

             circle.borColor = BColor.BackColor;
             circle.brushColor = cbColor.Checked ? panelBrushColor.BackColor : Color.Empty;

             circle.Show();
             figures.Add(circle);

             tbfig.Text = circle.GetSquare().ToString();
             tbsquare.Text = GetTotalSquare().ToString();*/
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            int diameter = rand.Next(minSize.Width, maxSize.Width + 1);

            Circle circle = new Circle(indent, new Size(diameter, diameter));
            AddFigure(circle);


        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            Size size = new Size(rand.Next(minSize.Width, maxSize.Width + 1), rand.Next(minSize.Height, maxSize.Height + 1));

            Ellipse ellipse = new Ellipse(indent, size);
            AddFigure(ellipse);

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            Size size = new Size(rand.Next(minSize.Width, maxSize.Width + 1), rand.Next(minSize.Height, maxSize.Height + 1));

            Figure.Rectangle rect = new Figure.Rectangle(indent, size);

            rect.borColor = BColor.BackColor;
            rect.brushColor = cbColor.Checked ? panelBrushColor.BackColor : Color.Empty;

            rect.Show();
            figures.Add(rect);

            tbfig.Text = rect.GetSquare().ToString();
            tbsquare.Text = GetTotalSquare().ToString();

        }

        private void btnTrapezoid_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            Size size = new Size(rand.Next(minSize.Width, maxSize.Width + 1), rand.Next(minSize.Height, maxSize.Height + 1));
            float topBase = (float)(size.Width * 0.5);

            Trapezoid trapezoid = new Trapezoid(indent, size, topBase);

            trapezoid.borColor = BColor.BackColor;
            trapezoid.brushColor = cbColor.Checked ? panelBrushColor.BackColor : Color.Empty;


            trapezoid.Show();
            figures.Add(trapezoid);
            tbfig.Text = trapezoid.GetSquare().ToString();
            tbsquare.Text = GetTotalSquare().ToString();
        }

        private void btnRhombus_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            Size size = new Size(rand.Next(minSize.Width, maxSize.Width + 1), rand.Next(minSize.Height, maxSize.Height + 1));

            Rhombus rhombus = new Rhombus(indent, size);
            AddFigure(rhombus);

        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            Size size = new Size(rand.Next(minSize.Width, maxSize.Width + 1), rand.Next(minSize.Height, maxSize.Height + 1));

            Rectangular rectangularTriangle = new Rectangular(indent, size);

            rectangularTriangle.borColor = BColor.BackColor;
            rectangularTriangle.brushColor = cbColor.Checked ? panelBrushColor.BackColor : Color.Empty;

            rectangularTriangle.Show();
            figures.Add(rectangularTriangle);

            tbfig.Text = rectangularTriangle.GetSquare().ToString();
            tbsquare.Text = GetTotalSquare().ToString();
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            int side = rand.Next(minSize.Width, maxSize.Width + 1);

            Equilateral equilateralTriangle = new Equilateral(indent, new Size(side, (int)(side * Math.Sqrt(0.75))));

            equilateralTriangle.borColor = BColor.BackColor;
            equilateralTriangle.brushColor = cbColor.Checked ? panelBrushColor.BackColor : Color.Empty;

            equilateralTriangle.Show();
            figures.Add(equilateralTriangle);

            tbfig.Text = equilateralTriangle.GetSquare().ToString();
            tbsquare.Text = GetTotalSquare().ToString();
        }

        private void btnAddGeneral_Click(object sender, EventArgs e)
        {
        }

        private void btnPyramid_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            Size size = new Size(rand.Next(minSize.Width, maxSize.Width + 1), rand.Next(minSize.Height, maxSize.Height + 1));

            Pyramid pyramid = new Pyramid(indent, size);
            AddFigure(pyramid);

        }

        private void btnSphere_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            int diameter = rand.Next(minSize.Width, maxSize.Width + 1);
            
            Sphere sphere = new Sphere(indent, new Size(diameter, diameter));

            sphere.borColor = BColor.BackColor;
            sphere.brushColor = cbColor.Checked ? panelBrushColor.BackColor : Color.Empty;

            sphere.Show();
            figures.Add(sphere);

            tbfig.Text = sphere.GetSquare().ToString();
            tbsquare.Text = GetTotalSquare().ToString();
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            Point indent = new Point(rand.Next(Figure.minp.X, Figure.maxp.X - maxSize.Width), rand.Next(Figure.minp.Y, Figure.maxp.Y - maxSize.Height));
            Size size = new Size(rand.Next(minSize.Width, maxSize.Width + 1), rand.Next(minSize.Height, maxSize.Height + 1));

            Cylinder cylinder = new Cylinder(indent, size);
            AddFigure(cylinder);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void chbAllowBrush_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbFigureSquare_TextChanged(object sender, EventArgs e)
        {

        }

        private void BColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBrushColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (figures.Count > 0)
            {
                int ds = e.NewValue - e.OldValue; 
                foreach (var figure in figures)
                {
                    figure.scale(ds);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog1.FileName, FileMode.Create)))
                {
                    writer.Write(figures.Count);

                    foreach (Figure figure in figures)
                    {
                        writer.Write(figure.p.X);
                        writer.Write(figure.p.Y);

                        writer.Write(figure.size.Width);
                        writer.Write(figure.size.Height);

                        writer.Write(figure.type);

                        writer.Write(figure.borColor.A);
                        writer.Write(figure.borColor.R);
                        writer.Write(figure.borColor.G);
                        writer.Write(figure.borColor.B);

                        writer.Write(figure.brushColor.A);
                        writer.Write(figure.brushColor.R);
                        writer.Write(figure.brushColor.G);
                        writer.Write(figure.brushColor.B);
                    }
                }
            }
        }
        private void AddFigure(Figure figure)
        {
            if (figure.borColor == Color.Empty)
            {
                figure.borColor = cbcbor.Checked ? BColor.BackColor : Color.Empty;
            }
            if (figure.brushColor == Color.Empty)
            {
                figure.brushColor = cbColor.Checked ? panelBrushColor.BackColor : Color.Empty;
            }

            if (figure.borColor != Color.Empty || figure.brushColor != Color.Empty)
            {
                selectedFigure = figure;
                figures.Add(figure);
                figure.Show();

                tbfig.Text = figure.GetSquare().ToString();
                tbsquare.Text = GetTotalSquare().ToString();

            }
        }
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open)))
                {
                    int figuresCount = reader.ReadInt32();
                    btnclear_Click(sender, e);

                    for (int i = 0; i < figuresCount; ++i)
                    {
                        int tempX = reader.ReadInt32();
                        int tempY = reader.ReadInt32();

                        int tempWidth = reader.ReadInt32();
                        int tempHeight = reader.ReadInt32();

                        string tempType = reader.ReadString();
                        Point tempPoint = new Point(tempX, tempY);
                        Size tempSize = new Size(tempWidth, tempHeight);

                        selectedFigure = NewFigure(tempType, tempPoint, tempSize);

                        byte tempA, tempR, tempG, tempB;

                        tempA = reader.ReadByte();
                        tempR = reader.ReadByte();
                        tempG = reader.ReadByte();
                        tempB = reader.ReadByte();

                        selectedFigure.borColor = Color.FromArgb(tempA, tempR, tempG, tempB);

                        tempA = reader.ReadByte();
                        tempR = reader.ReadByte();
                        tempG = reader.ReadByte();
                        tempB = reader.ReadByte();

                        selectedFigure.brushColor = Color.FromArgb(tempA, tempR, tempG, tempB);

                        try
                        {
                            AddFigure(selectedFigure);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Figure figure in figures)
            {
                figure.Hide();
            }

            figures.Clear();
            selectedFigure = null;

            tbfig.Text = tbsquare.Text = 0.ToString();
            tbwidth.Text = tbheight.Text = 0.ToString();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsize_Click(object sender, EventArgs e)
        {
            int newWidth, newHeight;
            int.TryParse(tbwidth.Text, out newWidth);
            int.TryParse(tbheight.Text, out newHeight);

            if (newWidth >= minSize.Width && newHeight >= minSize.Height && newWidth <= maxSize.Width && newHeight <= maxSize.Height)
            {
                selectedFigure.Resize(newWidth, newHeight);
                ShowAll();
            }
            if (selectedFigure != null)
            {
                selectedFigure.Resize(newWidth, newHeight);
                ShowAll();
            }
            else
            {
                MessageBox.Show("фигура");
            }
        }

        private void tbwidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int newWidth;
                int.TryParse(tbwidth.Text, out newWidth);

                if (newWidth >= minSize.Width && newWidth <= maxSize.Width)
                {
                    selectedFigure.Hide();
                    selectedFigure.size.Width = int.Parse(tbwidth.Text);
                    selectedFigure.Show();
                }
                else
                {
                    MessageBox.Show("Enter correct width!");
                }
            }
        }

        private void tbheight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int newHeight;
                int.TryParse(tbheight.Text, out newHeight);

                if (newHeight >= minSize.Height && newHeight <= maxSize.Height)
                {
                    selectedFigure.Hide();
                    selectedFigure.size.Height = int.Parse(tbheight.Text);
                    selectedFigure.Show();
                }
            }
        }

        private void tbwidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void cbcbor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbheight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}