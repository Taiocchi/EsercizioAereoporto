﻿namespace Aereoporto
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
            Decolla = new Button();
            comboBox1 = new ComboBox();
            Atterra = new Button();
            ListaDecolli = new ListBox();
            ListaAtterraggi = new ListBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Decolla
            // 
            Decolla.Location = new Point(42, 144);
            Decolla.Name = "Decolla";
            Decolla.Size = new Size(133, 49);
            Decolla.TabIndex = 0;
            Decolla.Text = "Decolla";
            Decolla.UseVisualStyleBackColor = true;
            Decolla.Click += Decolla_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Boeing - 737 ", "Boeing - 747 ", "Boeing - 777", "Boeing - 787 ", "Airbus - A320 ", "Airbus - A330", "Airbus - A350 XWB", "Airbus - A380", "Embraer - E-Jet Series", "Embraer - E2 Series", "Bombardier - A220 ", "Bombardier - CRJ Series" });
            comboBox1.Location = new Point(42, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 1;
            // 
            // Atterra
            // 
            Atterra.Location = new Point(42, 226);
            Atterra.Name = "Atterra";
            Atterra.Size = new Size(133, 49);
            Atterra.TabIndex = 2;
            Atterra.Text = "Atterra";
            Atterra.UseVisualStyleBackColor = true;
            Atterra.Click += Atterra_Click;
            // 
            // ListaDecolli
            // 
            ListaDecolli.FormattingEnabled = true;
            ListaDecolli.ItemHeight = 15;
            ListaDecolli.Location = new Point(359, 57);
            ListaDecolli.Name = "ListaDecolli";
            ListaDecolli.Size = new Size(158, 94);
            ListaDecolli.TabIndex = 4;
            // 
            // ListaAtterraggi
            // 
            ListaAtterraggi.FormattingEnabled = true;
            ListaAtterraggi.ItemHeight = 15;
            ListaAtterraggi.Location = new Point(584, 59);
            ListaAtterraggi.Name = "ListaAtterraggi";
            ListaAtterraggi.Size = new Size(158, 94);
            ListaAtterraggi.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 39);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Lista decolli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 39);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 7;
            label2.Text = "Lista atterraggi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.aereo;
            pictureBox1.Location = new Point(439, 229);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 122);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pista2;
            pictureBox2.Location = new Point(345, 357);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(397, 51);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 250);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListaAtterraggi);
            Controls.Add(ListaDecolli);
            Controls.Add(Atterra);
            Controls.Add(comboBox1);
            Controls.Add(Decolla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Decolla;
        private ComboBox comboBox1;
        private Button Atterra;
        private ListBox ListaDecolli;
        private ListBox ListaAtterraggi;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
    }
}
