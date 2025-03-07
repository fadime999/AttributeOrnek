namespace WinFormsAppAttribute
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            ADI = new Label();
            SOYADI = new Label();
            BÖLÜM = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(326, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(326, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(352, 258);
            button1.Name = "button1";
            button1.Size = new Size(99, 44);
            button1.TabIndex = 3;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ADI
            // 
            ADI.AutoSize = true;
            ADI.Location = new Point(251, 79);
            ADI.Name = "ADI";
            ADI.Size = new Size(51, 25);
            ADI.TabIndex = 4;
            ADI.Text = "ADI :";
            // 
            // SOYADI
            // 
            SOYADI.AutoSize = true;
            SOYADI.Location = new Point(227, 154);
            SOYADI.Name = "SOYADI";
            SOYADI.Size = new Size(84, 25);
            SOYADI.TabIndex = 5;
            SOYADI.Text = "SOYADI :";
            // 
            // BÖLÜM
            // 
            BÖLÜM.AutoSize = true;
            BÖLÜM.Location = new Point(227, 215);
            BÖLÜM.Name = "BÖLÜM";
            BÖLÜM.Size = new Size(86, 25);
            BÖLÜM.TabIndex = 6;
            BÖLÜM.Text = "BÖLÜM : ";
            BÖLÜM.Click += BÖLÜM_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BÖLÜM);
            Controls.Add(SOYADI);
            Controls.Add(ADI);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label ADI;
        private Label SOYADI;
        private Label BÖLÜM;
    }
}
