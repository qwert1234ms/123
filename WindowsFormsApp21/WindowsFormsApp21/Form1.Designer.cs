namespace WindowsFormsApp21
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
            this.buttoncolor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonopen1 = new System.Windows.Forms.Button();
            this.buttonopen2 = new System.Windows.Forms.Button();
            this.buttonopen3 = new System.Windows.Forms.Button();
            this.buttoncolor2 = new System.Windows.Forms.Button();
            this.buttoncolor3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttoncolor
            // 
            this.buttoncolor.Location = new System.Drawing.Point(111, 277);
            this.buttoncolor.Name = "buttoncolor";
            this.buttoncolor.Size = new System.Drawing.Size(89, 23);
            this.buttoncolor.TabIndex = 1;
            this.buttoncolor.Text = "Full image";
            this.buttoncolor.UseVisualStyleBackColor = true;
            this.buttoncolor.Visible = false;
            this.buttoncolor.Click += new System.EventHandler(this.buttoncolor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 270);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Выбор файла изображения";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(294, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 270);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(568, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 267);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // buttonopen1
            // 
            this.buttonopen1.Location = new System.Drawing.Point(12, 276);
            this.buttonopen1.Name = "buttonopen1";
            this.buttonopen1.Size = new System.Drawing.Size(93, 23);
            this.buttonopen1.TabIndex = 4;
            this.buttonopen1.Text = "Open file";
            this.buttonopen1.UseVisualStyleBackColor = true;
            this.buttonopen1.Visible = false;
            this.buttonopen1.Click += new System.EventHandler(this.buttonopen1_Click);
            // 
            // buttonopen2
            // 
            this.buttonopen2.Location = new System.Drawing.Point(303, 276);
            this.buttonopen2.Name = "buttonopen2";
            this.buttonopen2.Size = new System.Drawing.Size(85, 23);
            this.buttonopen2.TabIndex = 5;
            this.buttonopen2.Text = "Open file";
            this.buttonopen2.UseVisualStyleBackColor = true;
            this.buttonopen2.Visible = false;
            this.buttonopen2.Click += new System.EventHandler(this.buttonopen2_Click);
            // 
            // buttonopen3
            // 
            this.buttonopen3.Location = new System.Drawing.Point(592, 276);
            this.buttonopen3.Name = "buttonopen3";
            this.buttonopen3.Size = new System.Drawing.Size(69, 23);
            this.buttonopen3.TabIndex = 6;
            this.buttonopen3.Text = "Open file";
            this.buttonopen3.UseVisualStyleBackColor = true;
            this.buttonopen3.Visible = false;
            this.buttonopen3.Click += new System.EventHandler(this.buttonopen3_Click);
            // 
            // buttoncolor2
            // 
            this.buttoncolor2.Location = new System.Drawing.Point(394, 277);
            this.buttoncolor2.Name = "buttoncolor2";
            this.buttoncolor2.Size = new System.Drawing.Size(73, 23);
            this.buttoncolor2.TabIndex = 7;
            this.buttoncolor2.Text = "Full image";
            this.buttoncolor2.UseVisualStyleBackColor = true;
            this.buttoncolor2.Visible = false;
            this.buttoncolor2.Click += new System.EventHandler(this.buttoncolor2_Click);
            // 
            // buttoncolor3
            // 
            this.buttoncolor3.Location = new System.Drawing.Point(667, 279);
            this.buttoncolor3.Name = "buttoncolor3";
            this.buttoncolor3.Size = new System.Drawing.Size(74, 23);
            this.buttoncolor3.TabIndex = 8;
            this.buttoncolor3.Text = "Full image";
            this.buttoncolor3.UseVisualStyleBackColor = true;
            this.buttoncolor3.Visible = false;
            this.buttoncolor3.Click += new System.EventHandler(this.buttoncolor3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(747, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Open File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(847, 526);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(135, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 526);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttoncolor3);
            this.Controls.Add(this.buttoncolor2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttoncolor);
            this.Controls.Add(this.buttonopen3);
            this.Controls.Add(this.buttonopen2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonopen1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttoncolor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonopen1;
        private System.Windows.Forms.Button buttonopen2;
        private System.Windows.Forms.Button buttonopen3;
        private System.Windows.Forms.Button buttoncolor2;
        private System.Windows.Forms.Button buttoncolor3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button5;
    }
}

