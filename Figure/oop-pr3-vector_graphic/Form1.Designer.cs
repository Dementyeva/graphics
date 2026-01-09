namespace Figures
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.panelBrushColor = new System.Windows.Forms.Panel();
            this.BColor = new System.Windows.Forms.Panel();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.btnSphere = new System.Windows.Forms.Button();
            this.btnPyramid = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTrapezoid = new System.Windows.Forms.Button();
            this.btnRhombus = new System.Windows.Forms.Button();
            this.tbfig = new System.Windows.Forms.TextBox();
            this.tbsquare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.CheckBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnclear = new System.Windows.Forms.Button();
            this.tbwidth = new System.Windows.Forms.TextBox();
            this.tbheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsize = new System.Windows.Forms.Button();
            this.cbcbor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(766, 29);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(65, 47);
            this.btnMoveLeft.TabIndex = 18;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(922, 29);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 47);
            this.btnMoveRight.TabIndex = 17;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(839, 68);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 40);
            this.btnMoveDown.TabIndex = 16;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(839, 13);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 47);
            this.btnMoveUp.TabIndex = 15;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // panelBrushColor
            // 
            this.panelBrushColor.BackColor = System.Drawing.Color.Black;
            this.panelBrushColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrushColor.Location = new System.Drawing.Point(1186, 33);
            this.panelBrushColor.Margin = new System.Windows.Forms.Padding(4);
            this.panelBrushColor.Name = "panelBrushColor";
            this.panelBrushColor.Size = new System.Drawing.Size(46, 43);
            this.panelBrushColor.TabIndex = 9;
            this.panelBrushColor.Click += new System.EventHandler(this.panelBorderColor_Click);
            this.panelBrushColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBrushColor_Paint);
            // 
            // BColor
            // 
            this.BColor.BackColor = System.Drawing.Color.Black;
            this.BColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BColor.Location = new System.Drawing.Point(1119, 33);
            this.BColor.Margin = new System.Windows.Forms.Padding(4);
            this.BColor.Name = "BColor";
            this.BColor.Size = new System.Drawing.Size(46, 43);
            this.BColor.TabIndex = 7;
            this.BColor.Click += new System.EventHandler(this.panelBorderColor_Click);
            this.BColor.Paint += new System.Windows.Forms.PaintEventHandler(this.BColor_Paint);
            // 
            // btnCylinder
            // 
            this.btnCylinder.Location = new System.Drawing.Point(443, 68);
            this.btnCylinder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(85, 40);
            this.btnCylinder.TabIndex = 5;
            this.btnCylinder.Text = "Cylinder";
            this.btnCylinder.UseVisualStyleBackColor = true;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // btnSphere
            // 
            this.btnSphere.Location = new System.Drawing.Point(353, 66);
            this.btnSphere.Margin = new System.Windows.Forms.Padding(4);
            this.btnSphere.Name = "btnSphere";
            this.btnSphere.Size = new System.Drawing.Size(82, 42);
            this.btnSphere.TabIndex = 4;
            this.btnSphere.Text = "Sphere";
            this.btnSphere.UseVisualStyleBackColor = true;
            this.btnSphere.Click += new System.EventHandler(this.btnSphere_Click);
            // 
            // btnPyramid
            // 
            this.btnPyramid.Location = new System.Drawing.Point(441, 14);
            this.btnPyramid.Margin = new System.Windows.Forms.Padding(4);
            this.btnPyramid.Name = "btnPyramid";
            this.btnPyramid.Size = new System.Drawing.Size(87, 45);
            this.btnPyramid.TabIndex = 3;
            this.btnPyramid.Text = "Pyramid";
            this.btnPyramid.UseVisualStyleBackColor = true;
            this.btnPyramid.Click += new System.EventHandler(this.btnPyramid_Click);
            // 
            // btnEq
            // 
            this.btnEq.Location = new System.Drawing.Point(248, 68);
            this.btnEq.Margin = new System.Windows.Forms.Padding(4);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(97, 40);
            this.btnEq.TabIndex = 4;
            this.btnEq.Text = "Equilateral";
            this.btnEq.UseVisualStyleBackColor = true;
            this.btnEq.Click += new System.EventHandler(this.btnEq_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(327, 13);
            this.btnRect.Margin = new System.Windows.Forms.Padding(4);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(108, 47);
            this.btnRect.TabIndex = 3;
            this.btnRect.Text = "Rectangular";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(41, 68);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(80, 44);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(41, 13);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(80, 47);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(222, 13);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(97, 47);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTrapezoid
            // 
            this.btnTrapezoid.Location = new System.Drawing.Point(129, 13);
            this.btnTrapezoid.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrapezoid.Name = "btnTrapezoid";
            this.btnTrapezoid.Size = new System.Drawing.Size(85, 47);
            this.btnTrapezoid.TabIndex = 1;
            this.btnTrapezoid.Text = "Trapezoid";
            this.btnTrapezoid.UseVisualStyleBackColor = true;
            this.btnTrapezoid.Click += new System.EventHandler(this.btnTrapezoid_Click);
            // 
            // btnRhombus
            // 
            this.btnRhombus.Location = new System.Drawing.Point(129, 68);
            this.btnRhombus.Margin = new System.Windows.Forms.Padding(4);
            this.btnRhombus.Name = "btnRhombus";
            this.btnRhombus.Size = new System.Drawing.Size(111, 44);
            this.btnRhombus.TabIndex = 2;
            this.btnRhombus.Text = "Rhomb";
            this.btnRhombus.UseVisualStyleBackColor = true;
            this.btnRhombus.Click += new System.EventHandler(this.btnRhombus_Click);
            // 
            // tbfig
            // 
            this.tbfig.Location = new System.Drawing.Point(960, 83);
            this.tbfig.Name = "tbfig";
            this.tbfig.Size = new System.Drawing.Size(100, 22);
            this.tbfig.TabIndex = 19;
            // 
            // tbsquare
            // 
            this.tbsquare.Location = new System.Drawing.Point(1077, 83);
            this.tbsquare.Name = "tbsquare";
            this.tbsquare.Size = new System.Drawing.Size(100, 22);
            this.tbsquare.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1031, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "square\r\n";
            // 
            // cbColor
            // 
            this.cbColor.AutoSize = true;
            this.cbColor.Location = new System.Drawing.Point(1173, 12);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(59, 20);
            this.cbColor.TabIndex = 23;
            this.cbColor.Text = "color";
            this.cbColor.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 2;
            this.hScrollBar1.Location = new System.Drawing.Point(545, 13);
            this.hScrollBar1.Maximum = 300;
            this.hScrollBar1.Minimum = 50;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(173, 24);
            this.hScrollBar1.TabIndex = 24;
            this.hScrollBar1.Value = 100;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(545, 53);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(57, 23);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(608, 53);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(54, 23);
            this.btnopen.TabIndex = 26;
            this.btnopen.Text = "open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(668, 53);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(54, 23);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // tbwidth
            // 
            this.tbwidth.Location = new System.Drawing.Point(545, 82);
            this.tbwidth.Name = "tbwidth";
            this.tbwidth.Size = new System.Drawing.Size(73, 22);
            this.tbwidth.TabIndex = 29;
            this.tbwidth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbwidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbwidth_KeyDown);
            this.tbwidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbwidth_KeyPress);
            // 
            // tbheight
            // 
            this.tbheight.Location = new System.Drawing.Point(624, 82);
            this.tbheight.Name = "tbheight";
            this.tbheight.Size = new System.Drawing.Size(68, 22);
            this.tbheight.TabIndex = 30;
            this.tbheight.TextChanged += new System.EventHandler(this.tbheight_TextChanged);
            this.tbheight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbheight_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "height";
            // 
            // btnsize
            // 
            this.btnsize.Location = new System.Drawing.Point(698, 82);
            this.btnsize.Name = "btnsize";
            this.btnsize.Size = new System.Drawing.Size(54, 23);
            this.btnsize.TabIndex = 33;
            this.btnsize.Text = "size";
            this.btnsize.UseVisualStyleBackColor = true;
            this.btnsize.Click += new System.EventHandler(this.btnsize_Click);
            // 
            // cbcbor
            // 
            this.cbcbor.AutoSize = true;
            this.cbcbor.Location = new System.Drawing.Point(1106, 12);
            this.cbcbor.Name = "cbcbor";
            this.cbcbor.Size = new System.Drawing.Size(59, 20);
            this.cbcbor.TabIndex = 34;
            this.cbcbor.Text = "color";
            this.cbcbor.UseVisualStyleBackColor = true;
            this.cbcbor.CheckedChanged += new System.EventHandler(this.cbcbor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 678);
            this.Controls.Add(this.cbcbor);
            this.Controls.Add(this.btnsize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbheight);
            this.Controls.Add(this.tbwidth);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbsquare);
            this.Controls.Add(this.tbfig);
            this.Controls.Add(this.btnCylinder);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnRhombus);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnSphere);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnEq);
            this.Controls.Add(this.btnPyramid);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.panelBrushColor);
            this.Controls.Add(this.btnTrapezoid);
            this.Controls.Add(this.BColor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.Button btnCylinder;
        private System.Windows.Forms.Button btnSphere;
        private System.Windows.Forms.Button btnPyramid;
        private System.Windows.Forms.Panel BColor;
        private System.Windows.Forms.Panel panelBrushColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnRhombus;
        private System.Windows.Forms.Button btnTrapezoid;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.TextBox tbfig;
        private System.Windows.Forms.TextBox tbsquare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbColor;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox tbwidth;
        private System.Windows.Forms.TextBox tbheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsize;
        private System.Windows.Forms.CheckBox cbcbor;
    }
}

