using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Ffigures
{
    public abstract class Figure
    {
        public static Graphics device;
        public static int PenWidth;

        public Point p;
        public static Point minp; 
        public static Point maxp; 
        public Size size;
        public string type { get; protected set; }


        public Color borColor;
        public Color brushColor;
        public static Color BackgroundColor;

        public Figure()
        {
            borColor = Color.Black ;
            brushColor = Color.Empty;
            type = "Unknown";
        }

        protected abstract void draw(Color clBorder, Color brBorder);

        public void Show()
        {
            draw(this.borColor, this.brushColor);
        }

        public void Hide()
        {
            draw(Figure.BackgroundColor, Figure.BackgroundColor);
        }

        public void scale(int ds)
        {
            Hide();
            size.Width += ds;
            size.Height += ds;
            Show();
        }




        public virtual void move(int x, int y)
        {
            Hide();

            if (p.X + x >= minp.X && p.X + x + size.Width <= maxp.X)
            {
                p.X += x;
            }

            if (p.Y + y >= minp.Y && p.Y + y + size.Height <= maxp.Y)
            {
                p.Y += y;
            }

            Show();
        }

        public abstract float GetSquare();

        public void Resize(int width, int height)
        {
            Hide();
            size.Width = width;
            size.Height = height;
            Show();
        }

///ПІРАМІДА
        public abstract class Figure3D : Figure { }

        public class Pyramid : Figure3D          
        {
            public Pyramid(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Pyramid";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                Pen solidPen = new Pen(clBorder, 1);
                Pen dashedPen = new Pen(clBorder, 1) { DashPattern = new float[] { 5, 5 } };

                int x0 = p.X;
                int y0 = p.Y;

                int width = size.Width;
                int height = size.Height;

                int halfWidth = width / 2;
                int bottomY = y0 + height;

                PointF top = new PointF(x0 + halfWidth, y0);
                PointF baseLeft = new PointF(x0, bottomY);
                PointF baseRight = new PointF(x0 + width, bottomY);
                PointF baseFront = new PointF(x0 + halfWidth, bottomY + halfWidth / 2);

                PointF[] points = new PointF[]
                {
                    top,
                    baseLeft,
                    baseFront,
                    baseRight,
                };

                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillPolygon(br, points);
                }

                device.DrawPolygon(solidPen, points);
                device.DrawLine(dashedPen, baseLeft, baseRight);
                device.DrawLine(solidPen, top, baseFront);
            }

            public override float GetSquare()
            {
                int side = this.size.Width;
                int height = this.size.Height;
                return (float)(side * (side + Math.Sqrt(4 * Math.Pow(height, 2) + Math.Pow(side, 2))));
            }
        }
//СФЕРА
        public class Sphere : Figure3D
        {
            public Sphere(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Sphere";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                int x0 = p.X;
                int y0 = p.Y;

                int width = size.Width;
                int halfHeight = size.Height / 2;
                int equatorY = y0 + size.Height / 2 - halfHeight / 2;

                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillEllipse(br, x0, y0, width, width);
                }

                Pen solidPen = new Pen(clBorder, PenWidth);
                Pen dashedPen = new Pen(clBorder, PenWidth);
                dashedPen.DashPattern = new float[] { 5, 5 };

                device.DrawEllipse(solidPen, x0, y0, width, width);
                device.DrawArc(dashedPen, x0, equatorY, width, halfHeight, 180, 180);
                device.DrawArc(solidPen, x0, equatorY, width, halfHeight, 0, 180);
            }
            public override float GetSquare()
            {
                int radius = this.size.Width / 2;
                return (float)(4 * Math.PI * Math.Pow(radius, 2));
            }

        }
//ЦИЛІНДР
        public class Cylinder : Figure3D
        {
            public Cylinder(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Cylinder";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                int x0 = p.X;
                int y0 = p.Y;

                int width = size.Width;
                int height = size.Height;

                int halfWidth = width / 2;
                int bottomY = y0 + height;

                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillEllipse(br, x0, bottomY - halfWidth, width, halfWidth);
                    device.FillEllipse(br, x0, y0, width, halfWidth);
                    device.FillRectangle(br, x0, y0 + halfWidth / 2, width, height - halfWidth);
                }

                Pen solidPen = new Pen(clBorder, PenWidth);
                Pen dashedPen = new Pen(clBorder, PenWidth);
                dashedPen.DashPattern = new float[] { 5, 5 };

                device.DrawLine(solidPen, x0, y0 + halfWidth / 2, x0, bottomY - halfWidth / 2);
                device.DrawLine(solidPen, x0 + width, y0 + halfWidth / 2, x0 + width, bottomY - halfWidth / 2);
                device.DrawEllipse(solidPen, x0, y0, width, halfWidth);
                device.DrawArc(dashedPen, x0, bottomY - halfWidth, width, halfWidth, 180, 180);
                device.DrawArc(solidPen, x0, bottomY - halfWidth, width, halfWidth, 0, 180);
            }

            public override float GetSquare()
            {
                int radius = this.size.Width / 2;
                return (float)(2 * Math.PI * radius * (radius + this.size.Height));
            }

        }

        public abstract class Figure2D : Figure { }

        public abstract class Quadrangle : Figure { }

        public abstract class Curve : Figure { }

        public abstract class Triangle : Figure { }

//ЧОТИРИКУТНИК

        public class Rectangle : Quadrangle
        {
            public Rectangle(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Rectangle";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillRectangle(br, base.p.X, base.p.Y, size.Width, size.Width);
                }

                Pen p = new Pen(clBorder, PenWidth);
                device.DrawRectangle(p, base.p.X, base.p.Y, size.Width, size.Width);
            }
            public override float GetSquare()
            {
                return this.size.Width * this.size.Height;
            }

        }
//ТРАПЕЦІЯ
        public class Trapezoid : Quadrangle
        {
            public Trapezoid(Point p, Size size, float topBase)
            {
                base.p = p;
                base.size = size;
                TopBaseWidth = topBase;
                this.type = "Trapezoid";
            }

            public float TopBaseWidth = 0;

            protected override void draw(Color clBorder, Color brBorder)
            {
                int x0 = base.p.X;
                int y0 = base.p.Y;

                float dif = (size.Width - TopBaseWidth) / 2;

                PointF[] points = new PointF[]
                {
                    new PointF(x0 + dif, y0),
                    new PointF(x0 + dif + TopBaseWidth, y0),
                    new PointF(x0 + size.Width, y0 + size.Height),
                    new PointF(x0, y0 + size.Height),
                };

                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillPolygon(br, points);
                }

                Pen p = new Pen(clBorder, PenWidth);
                device.DrawPolygon(p, points);
            }
            public override float GetSquare()
            {
                return (float)(0.5 * (this.TopBaseWidth + this.size.Width) * this.size.Height);
            }

        }
 //РОМБ
        public class Rhombus : Quadrangle
        {
            public Rhombus(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Rhombus";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                int x0 = base.p.X;
                int y0 = base.p.Y;

                PointF[] points = new PointF[]
                {
                    new PointF((x0 * 2 + size.Width) / 2, y0),
                    new PointF(x0 + size.Width, (y0 * 2 + size.Height) / 2),
                    new PointF((x0 * 2 + size.Width) / 2, y0 + size.Height),
                    new PointF(x0, (y0 * 2 + size.Height) / 2),
                };

                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillPolygon(br, points);
                }

                Pen p = new Pen(clBorder, PenWidth);
                device.DrawPolygon(p, points);
            }
            public override float GetSquare()
            {
                int diagonal1 = this.size.Width;
                int diagonal2 = this.size.Height;

                return ((diagonal1 + diagonal2) / 2);
            }
        }

//КОЛО
        public class Circle : Curve
        {
            public Circle(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Circle";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillEllipse(br, base.p.X, base.p.Y, size.Width, size.Width);
                }

                Pen p = new Pen(clBorder, PenWidth);
                device.DrawEllipse(p, base.p.X, base.p.Y, size.Width, size.Width);
            }
            public override float GetSquare()
            {
                int radius = this.size.Width / 2;
                return (float)(Math.PI * radius * radius);
            }
        }
//ЕЛІПС
        public class Ellipse : Curve
        {
            public Ellipse(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Ellipse";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillEllipse(br, base.p.X, base.p.Y, size.Width, size.Height);
                }

                Pen p = new Pen(clBorder, PenWidth);
                device.DrawEllipse(p, base.p.X, base.p.Y, size.Width, size.Height);
            }
            public override float GetSquare()
            {
                int a = this.size.Width / 2;
                int b = this.size.Height / 2;

                return (float)(Math.PI * a * b);
            }
        }

//ТРИКУТНИКИ

        public class Rectangular : Triangle
        {
            public Rectangular(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Rectangular Triangle";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                int x0 = base.p.X;
                int y0 = base.p.Y;

                PointF[] points = new PointF[]
                {
                    new Point(x0, y0),
                    new Point(x0, y0 + size.Height),
                    new Point(x0 + size.Width, y0 + size.Height)
                };

                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillPolygon(br, points);
                }

                Pen p = new Pen(clBorder, PenWidth);
                device.DrawPolygon(p, points);
            }
            public override float GetSquare()
            {
                int cathetus1 = this.size.Width;
                int cathetus2 = this.size.Height;

                return cathetus1 * cathetus2 / 2;
            }

        }
//РІВНОСТОРОНІЙ ТРИКУТНИК
        public class Equilateral : Triangle
        {
            public Equilateral(Point p, Size size)
            {
                base.p = p;
                base.size = size;
                this.type = "Equilateral Triangle";
            }

            protected override void draw(Color clBorder, Color brBorder)
            {
                int x0 = base.p.X;
                int y0 = base.p.Y;

                PointF topPoint = new PointF((x0 * 2 + size.Width) / 2, base.p.Y);

                PointF[] points = new PointF[]
                {
                    topPoint,
                    new PointF(x0, y0 + size.Height),
                    new PointF(x0 + size.Width, y0 + size.Height),
                };

                if (brBorder != Color.Empty)
                {
                    Brush br = new SolidBrush(brBorder);
                    device.FillPolygon(br, points);
                }

                Pen p = new Pen(clBorder, PenWidth);
                device.DrawPolygon(p, points);
            }
            public override float GetSquare()
            {
                int size = this.size.Width;
                return (float)((Math.Sqrt(3) / 4) * Math.Pow(size, 2));
            }
        }
    }
}