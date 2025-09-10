namespace Aula_1
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
            btnSairbtnSair = new Button();
            button1 = new Button();
            btnLimpar = new Button();
            lblHW = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnSairbtnSair
            // 
            btnSairbtnSair.Font = new Font("Segoe UI", 19F);
            btnSairbtnSair.Location = new Point(41, 235);
            btnSairbtnSair.Name = "btnSairbtnSair";
            btnSairbtnSair.Size = new Size(229, 86);
            btnSairbtnSair.TabIndex = 0;
            btnSairbtnSair.Text = "Sair";
            btnSairbtnSair.UseVisualStyleBackColor = true;
            btnSairbtnSair.Click += btnSairbtnSair_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19F);
            button1.Location = new Point(678, 235);
            button1.Name = "button1";
            button1.Size = new Size(229, 86);
            button1.TabIndex = 1;
            button1.Text = "Exibir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 19F);
            btnLimpar.Location = new Point(354, 235);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(229, 86);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblHW
            // 
            lblHW.AutoSize = true;
            lblHW.Font = new Font("Comic Sans MS", 49F, FontStyle.Bold);
            lblHW.Location = new Point(334, 30);
            lblHW.Name = "lblHW";
            lblHW.Size = new Size(269, 91);
            lblHW.TabIndex = 4;
            lblHW.Text = "Cassino";
            lblHW.Click += lblHW_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(354, 193);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Texto a exibir";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 749);
            Controls.Add(textBox1);
            Controls.Add(lblHW);
            Controls.Add(btnLimpar);
            Controls.Add(button1);
            Controls.Add(btnSairbtnSair);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSairbtnSair;
        private Button button1;
        private Button btnLimpar;
        private Label lblHW;
        private TextBox textBox1;
    }
}
