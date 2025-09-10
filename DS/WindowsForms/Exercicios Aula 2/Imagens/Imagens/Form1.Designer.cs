namespace Imagens
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            checkBox2 = new CheckBox();
            groupBox4 = new GroupBox();
            radioClaro = new RadioButton();
            radioButton2 = new RadioButton();
            btnSair = new Button();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            cbTrocaImagem = new CheckBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(498, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 323);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(35, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(191, 250);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Estilo";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Black", 11.75F, FontStyle.Bold);
            checkBox2.Location = new Point(57, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 25);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Borda";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioClaro);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Location = new Point(8, 97);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(175, 145);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fundo";
            // 
            // radioClaro
            // 
            radioClaro.AutoSize = true;
            radioClaro.Font = new Font("Segoe UI Black", 11.75F, FontStyle.Bold);
            radioClaro.Location = new Point(26, 85);
            radioClaro.Name = "radioClaro";
            radioClaro.Size = new Size(122, 25);
            radioClaro.TabIndex = 5;
            radioClaro.TabStop = true;
            radioClaro.Text = "Fundo Claro";
            radioClaro.UseVisualStyleBackColor = true;
            radioClaro.CheckedChanged += radioClaro_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Black", 11.75F, FontStyle.Bold);
            radioButton2.Location = new Point(21, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(133, 25);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fundo Escuro";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(251, 245);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(186, 55);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(251, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 88);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visibilidade";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Black", 11.75F, FontStyle.Bold);
            checkBox1.Location = new Point(16, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(155, 25);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Visivel/Invisivel";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbTrocaImagem
            // 
            cbTrocaImagem.AutoSize = true;
            cbTrocaImagem.Font = new Font("Segoe UI Black", 11.75F, FontStyle.Bold);
            cbTrocaImagem.Location = new Point(19, 48);
            cbTrocaImagem.Name = "cbTrocaImagem";
            cbTrocaImagem.Size = new Size(148, 25);
            cbTrocaImagem.TabIndex = 3;
            cbTrocaImagem.Text = "Trocar Imagem";
            cbTrocaImagem.UseVisualStyleBackColor = true;
            cbTrocaImagem.CheckedChanged += cbTrocaImagem_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbTrocaImagem);
            groupBox5.Location = new Point(251, 139);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(186, 100);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 344);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private Button btnSair;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private GroupBox groupBox4;
        private CheckBox checkBox2;
        private RadioButton radioClaro;
        private GroupBox groupBox5;
        private CheckBox cbTrocaImagem;
    }
}
