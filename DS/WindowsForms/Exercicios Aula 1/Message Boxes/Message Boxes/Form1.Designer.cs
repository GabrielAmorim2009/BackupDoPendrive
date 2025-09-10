namespace Message_Boxes
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
            Txt = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            SuspendLayout();
            // 
            // Txt
            // 
            Txt.AutoSize = true;
            Txt.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt.Location = new Point(122, 203);
            Txt.Name = "Txt";
            Txt.Size = new Size(430, 43);
            Txt.TabIndex = 0;
            Txt.Text = "Exemplos MessageBox";
            Txt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            btn1.Location = new Point(34, 336);
            btn1.Name = "btn1";
            btn1.Size = new Size(165, 76);
            btn1.TabIndex = 1;
            btn1.Text = "Exemplo 1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(257, 336);
            btn2.Name = "btn2";
            btn2.Size = new Size(165, 76);
            btn2.TabIndex = 4;
            btn2.Text = "Exemplo 2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(476, 336);
            btn3.Name = "btn3";
            btn3.Size = new Size(165, 76);
            btn3.TabIndex = 5;
            btn3.Text = "Exemplo 3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 612);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(Txt);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Txt;
        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}
