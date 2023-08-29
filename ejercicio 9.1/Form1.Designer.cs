namespace ejercicio_9._1
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
            lblresultado = new Button();
            num1 = new Label();
            textBox1 = new TextBox();
            num2 = new Label();
            textBox2 = new TextBox();
            num3 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblresultado
            // 
            lblresultado.Location = new Point(196, 238);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(158, 56);
            lblresultado.TabIndex = 0;
            lblresultado.Text = "ejecutar";
            lblresultado.UseVisualStyleBackColor = true;
            lblresultado.Click += button1_Click;
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(123, 81);
            num1.Name = "num1";
            num1.Size = new Size(38, 15);
            num1.TabIndex = 1;
            num1.Text = "num1\r\n";
            num1.Click += num1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 2;
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(123, 129);
            num2.Name = "num2";
            num2.Size = new Size(38, 15);
            num2.TabIndex = 3;
            num2.Text = "num2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 4;
            // 
            // num3
            // 
            num3.AutoSize = true;
            num3.Location = new Point(123, 182);
            num3.Name = "num3";
            num3.Size = new Size(38, 15);
            num3.TabIndex = 5;
            num3.Text = "num3";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(119, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 26);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 8;
            label1.Text = "¿Cuál número es mayor?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(num3);
            Controls.Add(textBox2);
            Controls.Add(num2);
            Controls.Add(textBox1);
            Controls.Add(num1);
            Controls.Add(lblresultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lblresultado;
        private Label num1;
        private TextBox textBox1;
        private Label num2;
        private TextBox textBox2;
        private Label num3;
        private TextBox textBox3;
        private Label label1;
    }
}