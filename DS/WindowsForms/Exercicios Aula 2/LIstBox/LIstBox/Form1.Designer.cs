namespace LIstBox
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
            textBoxTXT = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxPosicao = new TextBox();
            textBoxTXTselect = new TextBox();
            textBoxTotal = new TextBox();
            buttonAdd = new Button();
            buttonEliminar = new Button();
            buttonLimpalista = new Button();
            buttonLimpar = new Button();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Digite um texto";
            // 
            // textBoxTXT
            // 
            textBoxTXT.Font = new Font("Segoe UI", 11F);
            textBoxTXT.Location = new Point(150, 11);
            textBoxTXT.Name = "textBoxTXT";
            textBoxTXT.Size = new Size(638, 27);
            textBoxTXT.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(566, 319);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 374);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Posição na lista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 400);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "Texto selecionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 426);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 5;
            label4.Text = "Total de itens";
            // 
            // textBoxPosicao
            // 
            textBoxPosicao.Location = new Point(106, 371);
            textBoxPosicao.Name = "textBoxPosicao";
            textBoxPosicao.Size = new Size(472, 23);
            textBoxPosicao.TabIndex = 6;
            textBoxPosicao.TextChanged += textBoxPosicao_TextChanged;
            // 
            // textBoxTXTselect
            // 
            textBoxTXTselect.Location = new Point(119, 397);
            textBoxTXTselect.Name = "textBoxTXTselect";
            textBoxTXTselect.Size = new Size(459, 23);
            textBoxTXTselect.TabIndex = 7;
            textBoxTXTselect.TextChanged += textBoxTXTselect_TextChanged;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(94, 423);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(484, 23);
            textBoxTotal.TabIndex = 8;
            textBoxTotal.TextChanged += textBoxTotal_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(584, 47);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(204, 67);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Adicionar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(584, 120);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(204, 67);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonLimpalista
            // 
            buttonLimpalista.Location = new Point(584, 193);
            buttonLimpalista.Name = "buttonLimpalista";
            buttonLimpalista.Size = new Size(204, 67);
            buttonLimpalista.TabIndex = 11;
            buttonLimpalista.Text = "Limpar lista";
            buttonLimpalista.UseVisualStyleBackColor = true;
            buttonLimpalista.Click += buttonLimpalista_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(584, 266);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(204, 67);
            buttonLimpar.TabIndex = 12;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonSair
            // 
            buttonSair.Location = new Point(584, 339);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(204, 107);
            buttonSair.TabIndex = 13;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSair);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonLimpalista);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxTXTselect);
            Controls.Add(textBoxPosicao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(textBoxTXT);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTXT;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxPosicao;
        private TextBox textBoxTXTselect;
        private TextBox textBoxTotal;
        private Button buttonAdd;
        private Button buttonEliminar;
        private Button buttonLimpalista;
        private Button buttonLimpar;
        private Button buttonSair;
    }
}
