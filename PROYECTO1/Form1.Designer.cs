namespace PROYECTO1
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
            this.chBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.chBox2 = new System.Windows.Forms.CheckBox();
            this.chBox3 = new System.Windows.Forms.CheckBox();
            this.chBox4 = new System.Windows.Forms.CheckBox();
            this.chBox5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chBox1
            // 
            this.chBox1.AutoSize = true;
            this.chBox1.Location = new System.Drawing.Point(24, 25);
            this.chBox1.Name = "chBox1";
            this.chBox1.Size = new System.Drawing.Size(92, 23);
            this.chBox1.TabIndex = 4;
            this.chBox1.Text = "checkBox1";
            this.chBox1.UseVisualStyleBackColor = true;
            this.chBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 315);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(178, 116);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 28);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Mostrar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // chBox2
            // 
            this.chBox2.AutoSize = true;
            this.chBox2.Location = new System.Drawing.Point(24, 75);
            this.chBox2.Name = "chBox2";
            this.chBox2.Size = new System.Drawing.Size(92, 23);
            this.chBox2.TabIndex = 7;
            this.chBox2.Text = "checkBox1";
            this.chBox2.UseVisualStyleBackColor = true;
            // 
            // chBox3
            // 
            this.chBox3.AutoSize = true;
            this.chBox3.Location = new System.Drawing.Point(24, 121);
            this.chBox3.Name = "chBox3";
            this.chBox3.Size = new System.Drawing.Size(95, 23);
            this.chBox3.TabIndex = 8;
            this.chBox3.Text = "Elipse lleno";
            this.chBox3.UseVisualStyleBackColor = true;
            // 
            // chBox4
            // 
            this.chBox4.AutoSize = true;
            this.chBox4.Location = new System.Drawing.Point(24, 171);
            this.chBox4.Name = "chBox4";
            this.chBox4.Size = new System.Drawing.Size(88, 23);
            this.chBox4.TabIndex = 9;
            this.chBox4.Text = "Cuadrado";
            this.chBox4.UseVisualStyleBackColor = true;
            // 
            // chBox5
            // 
            this.chBox5.AutoSize = true;
            this.chBox5.Location = new System.Drawing.Point(24, 232);
            this.chBox5.Name = "chBox5";
            this.chBox5.Size = new System.Drawing.Size(79, 23);
            this.chBox5.TabIndex = 10;
            this.chBox5.Text = "Random";
            this.chBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 317);
            this.Controls.Add(this.chBox5);
            this.Controls.Add(this.chBox4);
            this.Controls.Add(this.chBox3);
            this.Controls.Add(this.chBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chBox1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox chBox1;
        private PictureBox pictureBox1;
        private Button btn1;
        private CheckBox chBox2;
        private CheckBox chBox3;
        private CheckBox chBox4;
        private CheckBox chBox5;
    }
}