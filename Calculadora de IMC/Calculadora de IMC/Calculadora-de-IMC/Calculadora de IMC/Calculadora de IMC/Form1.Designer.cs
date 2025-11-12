namespace Calculadora_de_IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            txtIMC = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btncalcularIMC = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtIMC);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 207);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(23, 176);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 13;
            label9.Text = "Situação";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2738981;
            pictureBox2.Location = new Point(47, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(259, 66);
            label8.Name = "label8";
            label8.Size = new Size(25, 16);
            label8.TabIndex = 9;
            label8.Text = "Kg";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(259, 113);
            label7.Name = "label7";
            label7.Size = new Size(21, 16);
            label7.TabIndex = 8;
            label7.Text = "m";
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(164, 158);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(89, 23);
            txtIMC.TabIndex = 7;
            txtIMC.TextChanged += txtIMC_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(164, 111);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(89, 23);
            txtAltura.TabIndex = 6;
            txtAltura.Enter += txtAltura_Enter;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(164, 64);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(89, 23);
            txtPeso.TabIndex = 5;
            txtPeso.Enter += txtPeso_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(123, 160);
            label6.Name = "label6";
            label6.Size = new Size(35, 16);
            label6.TabIndex = 4;
            label6.Text = "IMC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(108, 113);
            label5.Name = "label5";
            label5.Size = new Size(50, 16);
            label5.TabIndex = 3;
            label5.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(116, 66);
            label4.Name = "label4";
            label4.Size = new Size(42, 16);
            label4.TabIndex = 2;
            label4.Text = "Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(63, 31);
            label3.Name = "label3";
            label3.Size = new Size(194, 16);
            label3.TabIndex = 1;
            label3.Text = "Informe seu Peso e Altura";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 6);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 0;
            label2.Text = "Cálculo de IMC";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(287, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(btncalcularIMC);
            panel4.Controls.Add(button12);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(12, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(320, 284);
            panel4.TabIndex = 2;
            panel4.Click += addNumber;
            panel4.Paint += panel4_Paint;
            // 
            // btncalcularIMC
            // 
            btncalcularIMC.BackColor = Color.Gold;
            btncalcularIMC.FlatStyle = FlatStyle.Flat;
            btncalcularIMC.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncalcularIMC.Location = new Point(42, 242);
            btncalcularIMC.Name = "btncalcularIMC";
            btncalcularIMC.Size = new Size(238, 28);
            btncalcularIMC.TabIndex = 13;
            btncalcularIMC.Text = "Calcular Índice de Massa Corporal";
            btncalcularIMC.UseVisualStyleBackColor = false;
            btncalcularIMC.Click += btncalcularIMC_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gold;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button12.Location = new Point(204, 186);
            button12.Name = "button12";
            button12.Size = new Size(75, 50);
            button12.TabIndex = 12;
            button12.Text = "Del";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button11.Location = new Point(123, 186);
            button11.Name = "button11";
            button11.Size = new Size(75, 50);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += addNumber;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button10.Location = new Point(42, 186);
            button10.Name = "button10";
            button10.Size = new Size(75, 50);
            button10.TabIndex = 10;
            button10.Text = ",";
            button10.UseVisualStyleBackColor = false;
            button10.Click += addNumber;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button9.Location = new Point(204, 130);
            button9.Name = "button9";
            button9.Size = new Size(75, 50);
            button9.TabIndex = 9;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = false;
            button9.Click += addNumber;
            // 
            // button8
            // 
            button8.BackColor = Color.Gold;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button8.Location = new Point(123, 130);
            button8.Name = "button8";
            button8.Size = new Size(75, 50);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += addNumber;
            // 
            // button7
            // 
            button7.BackColor = Color.Gold;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button7.Location = new Point(42, 130);
            button7.Name = "button7";
            button7.Size = new Size(75, 50);
            button7.TabIndex = 7;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = false;
            button7.Click += addNumber;
            // 
            // button6
            // 
            button6.BackColor = Color.Gold;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button6.Location = new Point(205, 74);
            button6.Name = "button6";
            button6.Size = new Size(75, 50);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += addNumber;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button5.Location = new Point(123, 74);
            button5.Name = "button5";
            button5.Size = new Size(75, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += addNumber;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button4.Location = new Point(42, 74);
            button4.Name = "button4";
            button4.Size = new Size(75, 50);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += addNumber;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button3.Location = new Point(205, 18);
            button3.Name = "button3";
            button3.Size = new Size(75, 50);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += addNumber;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button2.Location = new Point(123, 18);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += addNumber;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            button1.Location = new Point(42, 18);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += addNumber;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(344, 521);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private Label label8;
        private Label label7;
        private TextBox txtIMC;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btncalcularIMC;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
