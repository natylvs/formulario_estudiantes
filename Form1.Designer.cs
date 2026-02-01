namespace formulario_estudiante
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtn4 = new TextBox();
            txtn3 = new TextBox();
            txtn2 = new TextBox();
            txtn1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtp = new TextBox();
            groupBox3 = new GroupBox();
            txte = new TextBox();
            txtf = new TextBox();
            txtc = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            buttonc = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox5 = new GroupBox();
            label15 = new Label();
            txtp1 = new TextBox();
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 30);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 0;
            label1.Text = "Índice académico Estudiantil";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtn4);
            groupBox1.Controls.Add(txtn3);
            groupBox1.Controls.Add(txtn2);
            groupBox1.Controls.Add(txtn1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(13, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Notas Del Estudiante";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtn4
            // 
            txtn4.Location = new Point(82, 177);
            txtn4.Name = "txtn4";
            txtn4.Size = new Size(45, 29);
            txtn4.TabIndex = 3;
            // 
            // txtn3
            // 
            txtn3.Location = new Point(82, 90);
            txtn3.Name = "txtn3";
            txtn3.Size = new Size(45, 29);
            txtn3.TabIndex = 3;
            // 
            // txtn2
            // 
            txtn2.Location = new Point(82, 134);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(45, 29);
            txtn2.TabIndex = 3;
            // 
            // txtn1
            // 
            txtn1.Location = new Point(82, 48);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(45, 29);
            txtn1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 177);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 3;
            label6.Text = "Nota 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 137);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 3;
            label5.Text = "Nota 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 96);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 3;
            label4.Text = "Nota 2";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 51);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 3;
            label3.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 152);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtp);
            groupBox2.Location = new Point(266, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 61);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Promedio";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 51);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 1;
            label7.Click += label7_Click;
            // 
            // txtp
            // 
            txtp.Location = new Point(64, 20);
            txtp.Name = "txtp";
            txtp.Size = new Size(135, 29);
            txtp.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txte);
            groupBox3.Controls.Add(txtf);
            groupBox3.Controls.Add(txtc);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(14, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(262, 241);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Evaluacion Adicional";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txte
            // 
            txte.Location = new Point(29, 134);
            txte.Name = "txte";
            txte.Size = new Size(135, 29);
            txte.TabIndex = 7;
            // 
            // txtf
            // 
            txtf.Location = new Point(29, 191);
            txtf.Name = "txtf";
            txtf.Size = new Size(135, 29);
            txtf.TabIndex = 6;
            // 
            // txtc
            // 
            txtc.Location = new Point(29, 66);
            txtc.Name = "txtc";
            txtc.Size = new Size(135, 29);
            txtc.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 166);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 2;
            label10.Text = "Nota final;";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 105);
            label9.Name = "label9";
            label9.Size = new Size(188, 23);
            label9.TabIndex = 1;
            label9.Text = "Nota de extraordinario;";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 40);
            label8.Name = "label8";
            label8.Size = new Size(165, 23);
            label8.TabIndex = 0;
            label8.Text = "Nota de completivo;";
            label8.Click += label8_Click;
            // 
            // buttonc
            // 
            buttonc.BackColor = Color.LavenderBlush;
            buttonc.Location = new Point(728, 294);
            buttonc.Name = "buttonc";
            buttonc.Size = new Size(101, 31);
            buttonc.TabIndex = 5;
            buttonc.Text = "Calcular";
            buttonc.UseVisualStyleBackColor = false;
            buttonc.Click += buttonc_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(40, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 262);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(326, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 262);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(txtp1);
            groupBox5.Location = new Point(13, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(249, 95);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Promedio";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(89, 51);
            label15.Name = "label15";
            label15.Size = new Size(0, 23);
            label15.TabIndex = 1;
            // 
            // txtp1
            // 
            txtp1.Location = new Point(56, 45);
            txtp1.Name = "txtp1";
            txtp1.Size = new Size(135, 29);
            txtp1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Controls.Add(groupBox5);
            panel3.Location = new Point(639, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 120);
            panel3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 248);
            ClientSize = new Size(959, 452);
            Controls.Add(buttonc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 8.25F);
            ForeColor = Color.FromArgb(68, 68, 68);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtn4;
        private TextBox txtn3;
        private TextBox txtn2;
        private TextBox txtn1;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtp;
        private GroupBox groupBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txte;
        private TextBox txtf;
        private TextBox txtc;
        private Button buttonc;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox5;
        private Label label15;
        private TextBox txtp1;
        private Panel panel3;
    }
}
