namespace Combo_Box
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
            LBLtexto = new Label();
            TBtexto = new TextBox();
            LBLposição = new Label();
            LBLtextselect = new Label();
            LBLtotal = new Label();
            TBposicao = new TextBox();
            BTNadd = new Button();
            BTNsair = new Button();
            BTNlimpar = new Button();
            BTNeliminar = new Button();
            BTNlimplist = new Button();
            TBtextselect = new TextBox();
            TBtotal = new TextBox();
            comboBox1 = new ComboBox();
            LBLcombobox = new Label();
            SuspendLayout();
            // 
            // LBLtexto
            // 
            LBLtexto.AutoSize = true;
            LBLtexto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLtexto.Location = new Point(12, 26);
            LBLtexto.Name = "LBLtexto";
            LBLtexto.RightToLeft = RightToLeft.No;
            LBLtexto.Size = new Size(104, 15);
            LBLtexto.TabIndex = 0;
            LBLtexto.Text = "Digite um Texto";
            // 
            // TBtexto
            // 
            TBtexto.Font = new Font("Segoe UI", 15F);
            TBtexto.Location = new Point(120, 12);
            TBtexto.Name = "TBtexto";
            TBtexto.Size = new Size(606, 34);
            TBtexto.TabIndex = 1;
            TBtexto.KeyPress += TBtexto_KeyPress_1;
            // 
            // LBLposição
            // 
            LBLposição.AutoSize = true;
            LBLposição.Location = new Point(11, 128);
            LBLposição.Name = "LBLposição";
            LBLposição.Size = new Size(93, 15);
            LBLposição.TabIndex = 2;
            LBLposição.Text = "Posição Na Lista";
            // 
            // LBLtextselect
            // 
            LBLtextselect.AutoSize = true;
            LBLtextselect.Location = new Point(11, 184);
            LBLtextselect.Name = "LBLtextselect";
            LBLtextselect.Size = new Size(102, 15);
            LBLtextselect.TabIndex = 3;
            LBLtextselect.Text = "Texto Selecionado";
            // 
            // LBLtotal
            // 
            LBLtotal.AutoSize = true;
            LBLtotal.Location = new Point(11, 242);
            LBLtotal.Name = "LBLtotal";
            LBLtotal.Size = new Size(76, 15);
            LBLtotal.TabIndex = 4;
            LBLtotal.Text = "Total de Itens";
            // 
            // TBposicao
            // 
            TBposicao.Enabled = false;
            TBposicao.Font = new Font("Segoe UI", 15F);
            TBposicao.Location = new Point(107, 114);
            TBposicao.Name = "TBposicao";
            TBposicao.Size = new Size(427, 34);
            TBposicao.TabIndex = 5;
            // 
            // BTNadd
            // 
            BTNadd.Location = new Point(553, 54);
            BTNadd.Name = "BTNadd";
            BTNadd.Size = new Size(173, 50);
            BTNadd.TabIndex = 6;
            BTNadd.Text = "Adicionar";
            BTNadd.UseVisualStyleBackColor = true;
            BTNadd.Click += BTNadd_Click;
            // 
            // BTNsair
            // 
            BTNsair.Location = new Point(553, 283);
            BTNsair.Name = "BTNsair";
            BTNsair.Size = new Size(173, 50);
            BTNsair.TabIndex = 7;
            BTNsair.Text = "Sair";
            BTNsair.UseVisualStyleBackColor = true;
            BTNsair.Click += BTNsair_Click;
            // 
            // BTNlimpar
            // 
            BTNlimpar.Location = new Point(553, 227);
            BTNlimpar.Name = "BTNlimpar";
            BTNlimpar.Size = new Size(173, 50);
            BTNlimpar.TabIndex = 8;
            BTNlimpar.Text = "Limpar";
            BTNlimpar.UseVisualStyleBackColor = true;
            BTNlimpar.Click += BTNlimpar_Click;
            // 
            // BTNeliminar
            // 
            BTNeliminar.Location = new Point(553, 110);
            BTNeliminar.Name = "BTNeliminar";
            BTNeliminar.Size = new Size(173, 50);
            BTNeliminar.TabIndex = 9;
            BTNeliminar.Text = "Eliminar";
            BTNeliminar.UseVisualStyleBackColor = true;
            BTNeliminar.Click += BTNeliminar_Click;
            // 
            // BTNlimplist
            // 
            BTNlimplist.Location = new Point(553, 168);
            BTNlimplist.Name = "BTNlimplist";
            BTNlimplist.Size = new Size(173, 50);
            BTNlimplist.TabIndex = 10;
            BTNlimplist.Text = "Limpar Lista";
            BTNlimplist.UseVisualStyleBackColor = true;
            BTNlimplist.Click += BTNlimplist_Click;
            // 
            // TBtextselect
            // 
            TBtextselect.Enabled = false;
            TBtextselect.Font = new Font("Segoe UI", 15F);
            TBtextselect.Location = new Point(119, 170);
            TBtextselect.Name = "TBtextselect";
            TBtextselect.Size = new Size(415, 34);
            TBtextselect.TabIndex = 11;
            // 
            // TBtotal
            // 
            TBtotal.Enabled = false;
            TBtotal.Font = new Font("Segoe UI", 15F);
            TBtotal.Location = new Point(93, 228);
            TBtotal.Name = "TBtotal";
            TBtotal.Size = new Size(441, 34);
            TBtotal.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 21F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(453, 46);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LBLcombobox
            // 
            LBLcombobox.AutoSize = true;
            LBLcombobox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLcombobox.Location = new Point(11, 72);
            LBLcombobox.Name = "LBLcombobox";
            LBLcombobox.Size = new Size(68, 15);
            LBLcombobox.TabIndex = 14;
            LBLcombobox.Text = "DropDown";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 345);
            Controls.Add(LBLcombobox);
            Controls.Add(comboBox1);
            Controls.Add(TBtotal);
            Controls.Add(TBtextselect);
            Controls.Add(BTNlimplist);
            Controls.Add(BTNeliminar);
            Controls.Add(BTNlimpar);
            Controls.Add(BTNsair);
            Controls.Add(BTNadd);
            Controls.Add(TBposicao);
            Controls.Add(LBLtotal);
            Controls.Add(LBLtextselect);
            Controls.Add(LBLposição);
            Controls.Add(TBtexto);
            Controls.Add(LBLtexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLtexto;
        private TextBox TBtexto;
        private Label LBLposição;
        private Label LBLtextselect;
        private Label LBLtotal;
        private TextBox TBposicao;
        private Button BTNadd;
        private Button BTNsair;
        private Button BTNlimpar;
        private Button BTNeliminar;
        private Button BTNlimplist;
        private TextBox TBtextselect;
        private TextBox TBtotal;
        private ComboBox comboBox1;
        private Label LBLcombobox;
    }
}
