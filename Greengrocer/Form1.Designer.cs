namespace Greengrocer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nmTomatoKg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nmTomatoPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nmPatatoPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmPatatoKg = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nmPepperPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmPepperKg = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nmTomatoTotalKg = new System.Windows.Forms.NumericUpDown();
            this.nmPepperTotalKg = new System.Windows.Forms.NumericUpDown();
            this.nmPatatoTotalKg = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmTomatoKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTomatoPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatoPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatoKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPepperPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPepperKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTomatoTotalKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPepperTotalKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatoTotalKg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tomato";
            // 
            // nmTomatoKg
            // 
            this.nmTomatoKg.Location = new System.Drawing.Point(249, 80);
            this.nmTomatoKg.Name = "nmTomatoKg";
            this.nmTomatoKg.Size = new System.Drawing.Size(155, 22);
            this.nmTomatoKg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(246, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kg";
            // 
            // nmTomatoPrice
            // 
            this.nmTomatoPrice.Location = new System.Drawing.Point(473, 80);
            this.nmTomatoPrice.Name = "nmTomatoPrice";
            this.nmTomatoPrice.ReadOnly = true;
            this.nmTomatoPrice.Size = new System.Drawing.Size(141, 22);
            this.nmTomatoPrice.TabIndex = 3;
            this.nmTomatoPrice.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(473, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.nmPatatoTotalKg);
            this.groupBox1.Controls.Add(this.nmPepperTotalKg);
            this.groupBox1.Controls.Add(this.nmTomatoTotalKg);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmTotalPrice);
            this.groupBox1.Location = new System.Drawing.Point(67, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Price";
            // 
            // nmTotalPrice
            // 
            this.nmTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmTotalPrice.Location = new System.Drawing.Point(33, 44);
            this.nmTotalPrice.Name = "nmTotalPrice";
            this.nmTotalPrice.ReadOnly = true;
            this.nmTotalPrice.Size = new System.Drawing.Size(173, 30);
            this.nmTotalPrice.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(212, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "₺";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add to Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(473, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // nmPatatoPrice
            // 
            this.nmPatatoPrice.Location = new System.Drawing.Point(473, 143);
            this.nmPatatoPrice.Name = "nmPatatoPrice";
            this.nmPatatoPrice.ReadOnly = true;
            this.nmPatatoPrice.Size = new System.Drawing.Size(141, 22);
            this.nmPatatoPrice.TabIndex = 10;
            this.nmPatatoPrice.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(246, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kg";
            // 
            // nmPatatoKg
            // 
            this.nmPatatoKg.Location = new System.Drawing.Point(249, 143);
            this.nmPatatoKg.Name = "nmPatatoKg";
            this.nmPatatoKg.Size = new System.Drawing.Size(155, 22);
            this.nmPatatoKg.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Potato";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 31);
            this.button3.TabIndex = 18;
            this.button3.Text = "Add to Cart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(473, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Price";
            // 
            // nmPepperPrice
            // 
            this.nmPepperPrice.Location = new System.Drawing.Point(473, 209);
            this.nmPepperPrice.Name = "nmPepperPrice";
            this.nmPepperPrice.ReadOnly = true;
            this.nmPepperPrice.Size = new System.Drawing.Size(141, 22);
            this.nmPepperPrice.TabIndex = 16;
            this.nmPepperPrice.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(246, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kg";
            // 
            // nmPepperKg
            // 
            this.nmPepperKg.Location = new System.Drawing.Point(249, 209);
            this.nmPepperKg.Name = "nmPepperKg";
            this.nmPepperKg.Size = new System.Drawing.Size(155, 22);
            this.nmPepperKg.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(62, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Pepper";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(294, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tomato";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(294, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "Potato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(294, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Pepper";
            // 
            // nmTomatoTotalKg
            // 
            this.nmTomatoTotalKg.Location = new System.Drawing.Point(406, 16);
            this.nmTomatoTotalKg.Name = "nmTomatoTotalKg";
            this.nmTomatoTotalKg.ReadOnly = true;
            this.nmTomatoTotalKg.Size = new System.Drawing.Size(120, 22);
            this.nmTomatoTotalKg.TabIndex = 15;
            // 
            // nmPepperTotalKg
            // 
            this.nmPepperTotalKg.Location = new System.Drawing.Point(406, 72);
            this.nmPepperTotalKg.Name = "nmPepperTotalKg";
            this.nmPepperTotalKg.ReadOnly = true;
            this.nmPepperTotalKg.Size = new System.Drawing.Size(120, 22);
            this.nmPepperTotalKg.TabIndex = 16;
            // 
            // nmPatatoTotalKg
            // 
            this.nmPatatoTotalKg.Location = new System.Drawing.Point(406, 44);
            this.nmPatatoTotalKg.Name = "nmPatatoTotalKg";
            this.nmPatatoTotalKg.ReadOnly = true;
            this.nmPatatoTotalKg.Size = new System.Drawing.Size(120, 22);
            this.nmPatatoTotalKg.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(33, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 65);
            this.button4.TabIndex = 19;
            this.button4.Text = "New Customer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmPepperPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmPepperKg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmPatatoPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmPatatoKg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmTomatoPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmTomatoKg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grocer Ufuk";
            ((System.ComponentModel.ISupportInitialize)(this.nmTomatoKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTomatoPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatoPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatoKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPepperPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPepperKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTomatoTotalKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPepperTotalKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatoTotalKg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmTomatoKg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmTomatoPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmTotalPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmPatatoPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmPatatoKg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmPepperPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmPepperKg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmPatatoTotalKg;
        private System.Windows.Forms.NumericUpDown nmPepperTotalKg;
        private System.Windows.Forms.NumericUpDown nmTomatoTotalKg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
    }
}

