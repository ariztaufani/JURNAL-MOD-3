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
            cmbSatuanAwal = new ComboBox();
            cmbSatuanAkhir = new ComboBox();
            textNilaiAwal = new TextBox();
            textNilaiAkhir = new TextBox();
            btnConvert = new Button();
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
            // cmbSatuanAwal
            // 
            cmbSatuanAwal.FormattingEnabled = true;
            cmbSatuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cmbSatuanAwal.Location = new Point(90, 153);
            cmbSatuanAwal.Name = "cmbSatuanAwal";
            cmbSatuanAwal.Size = new Size(91, 28);
            cmbSatuanAwal.TabIndex = 4;
            // 
            // cmbSatuanAkhir
            // 
            cmbSatuanAkhir.FormattingEnabled = true;
            cmbSatuanAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cmbSatuanAkhir.Location = new Point(89, 270);
            cmbSatuanAkhir.Name = "cmbSatuanAkhir";
            cmbSatuanAkhir.Size = new Size(92, 28);
            cmbSatuanAkhir.TabIndex = 5;
            // 
            // textNilaiAwal
            // 
            textNilaiAwal.Location = new Point(239, 154);
            textNilaiAwal.Name = "textNilaiAwal";
            textNilaiAwal.Size = new Size(329, 27);
            textNilaiAwal.TabIndex = 6;
            textNilaiAwal.TextChanged += textNilaiAwal_TextChanged;
            // 
            // textNilaiAkhir
            // 
            textNilaiAkhir.Location = new Point(239, 271);
            textNilaiAkhir.Name = "textNilaiAkhir";
            textNilaiAkhir.ReadOnly = true;
            textNilaiAkhir.Size = new Size(329, 27);
            textNilaiAkhir.TabIndex = 7;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(620, 154);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 8;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(textNilaiAkhir);
            Controls.Add(textNilaiAwal);
            Controls.Add(cmbSatuanAkhir);
            Controls.Add(cmbSatuanAwal);
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
        private ComboBox cmbSatuanAwal;
        private ComboBox cmbSatuanAkhir;
        private TextBox textNilaiAwal;
        private TextBox textNilaiAkhir;
        private Button btnConvert;
    }
}
