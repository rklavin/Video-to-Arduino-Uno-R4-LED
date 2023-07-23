namespace mp4_to_Arduino_LED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            imageBox2 = new Emgu.CV.UI.ImageBox();
            button4 = new Button();
            trackBar1 = new TrackBar();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(593, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(87, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Input File:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(12, 356);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Convert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 44);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Output File:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(87, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 23);
            textBox2.TabIndex = 10;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(593, 40);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, -3);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Output Preview";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "Input Preview";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(12, 74);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(imageBox1);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(imageBox2);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(656, 248);
            splitContainer1.SplitterDistance = 328;
            splitContainer1.TabIndex = 12;
            // 
            // imageBox1
            // 
            imageBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
            imageBox1.Location = new Point(14, 18);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(300, 225);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            imageBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageBox2.BorderStyle = BorderStyle.FixedSingle;
            imageBox2.Location = new Point(14, 18);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(300, 225);
            imageBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox2.TabIndex = 2;
            imageBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(219, 356);
            button4.Name = "button4";
            button4.Size = new Size(120, 23);
            button4.TabIndex = 13;
            button4.Text = "Next Frame";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(358, 344);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(310, 45);
            trackBar1.TabIndex = 14;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(93, 356);
            button5.Name = "button5";
            button5.Size = new Size(120, 23);
            button5.TabIndex = 15;
            button5.Text = "Previous Frame";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown1.Location = new Point(12, 328);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(93, 330);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 17;
            label5.Text = "n Frames";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(249, 330);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 19;
            label6.Text = "Drop nth Frame";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown2.Location = new Point(168, 328);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(75, 23);
            numericUpDown2.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 391);
            Controls.Add(label6);
            Controls.Add(numericUpDown2);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(trackBar1);
            Controls.Add(button4);
            Controls.Add(splitContainer1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            MinimumSize = new Size(696, 430);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Label label4;
        private TextBox textBox2;
        private Button button3;
        private Label label3;
        private Label label2;
        private SplitContainer splitContainer1;
        private Button button4;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private TrackBar trackBar1;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown2;
    }
}