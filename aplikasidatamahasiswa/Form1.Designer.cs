namespace aplikasidatamahasiswa
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
            labelprodi = new TextBox();
            labelnama = new TextBox();
            pilpria = new RadioButton();
            pilwanita = new RadioButton();
            labeltmplahir = new TextBox();
            labeltgllahir = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 40);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Program Studi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 1;
            label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 181);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 2;
            label3.Text = "Nama Lengkap";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 257);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 3;
            label4.Text = "Tempat/Tgl Lahir";
            // 
            // labelprodi
            // 
            labelprodi.Location = new Point(254, 45);
            labelprodi.Name = "labelprodi";
            labelprodi.Size = new Size(150, 31);
            labelprodi.TabIndex = 4;
            labelprodi.TextChanged += labelprodi_TextChanged;
            // 
            // labelnama
            // 
            labelnama.Location = new Point(254, 178);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(150, 31);
            labelnama.TabIndex = 6;
            // 
            // pilpria
            // 
            pilpria.AutoSize = true;
            pilpria.Location = new Point(253, 120);
            pilpria.Name = "pilpria";
            pilpria.Size = new Size(100, 29);
            pilpria.TabIndex = 7;
            pilpria.TabStop = true;
            pilpria.Text = "Laki-laki";
            pilpria.UseVisualStyleBackColor = true;
            // 
            // pilwanita
            // 
            pilwanita.AutoSize = true;
            pilwanita.Location = new Point(428, 120);
            pilwanita.Name = "pilwanita";
            pilwanita.Size = new Size(126, 29);
            pilwanita.TabIndex = 8;
            pilwanita.TabStop = true;
            pilwanita.Text = "Perempuan";
            pilwanita.UseVisualStyleBackColor = true;
            // 
            // labeltmplahir
            // 
            labeltmplahir.Location = new Point(254, 257);
            labeltmplahir.Name = "labeltmplahir";
            labeltmplahir.Size = new Size(150, 31);
            labeltmplahir.TabIndex = 9;
            // 
            // labeltgllahir
            // 
            labeltgllahir.Location = new Point(446, 257);
            labeltgllahir.Name = "labeltgllahir";
            labeltgllahir.Size = new Size(300, 31);
            labeltgllahir.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(256, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(477, 404);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 664);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labeltgllahir);
            Controls.Add(labeltmplahir);
            Controls.Add(pilwanita);
            Controls.Add(pilpria);
            Controls.Add(labelnama);
            Controls.Add(labelprodi);
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
        private TextBox labelprodi;
        private TextBox labelnama;
        private RadioButton pilpria;
        private RadioButton pilwanita;
        private TextBox labeltempatlahir;
        private DateTimePicker labeltgllahir;
        private Button button1;
        private Button button2;
        private TextBox labeltmplahir;
    }
}
