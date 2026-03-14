namespace Modul3_103022400043
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 120);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Satuan Awal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 120);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Nilai Awal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 235);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Nilai Akhir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 235);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "Satuan Akhir";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBox1.Location = new Point(90, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(91, 28);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBox2.Location = new Point(89, 270);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(92, 28);
            comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 271);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(329, 27);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(620, 154);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
