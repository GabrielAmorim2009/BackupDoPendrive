namespace WinFormsApp1
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
            txt_id = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nome = new TextBox();
            txt_salario = new TextBox();
            cb_cargo = new ComboBox();
            groupBox1 = new GroupBox();
            btn_ver = new Button();
            btCadastrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(55, 33);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(121, 23);
            txt_id.TabIndex = 1;
            txt_id.TextChanged += txt_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 70);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 138);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Salário";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(55, 67);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(214, 23);
            txt_nome.TabIndex = 5;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(55, 135);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(121, 23);
            txt_salario.TabIndex = 7;
            txt_salario.TextChanged += txt_salario_TextChanged;
            // 
            // cb_cargo
            // 
            cb_cargo.FormattingEnabled = true;
            cb_cargo.Location = new Point(55, 101);
            cb_cargo.Name = "cb_cargo";
            cb_cargo.Size = new Size(121, 23);
            cb_cargo.TabIndex = 8;
            cb_cargo.SelectedIndexChanged += cb_cargo_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCadastrar);
            groupBox1.Controls.Add(btn_ver);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(cb_cargo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_salario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 200);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Funcionário";
            // 
            // btn_ver
            // 
            btn_ver.Location = new Point(194, 104);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(75, 23);
            btn_ver.TabIndex = 9;
            btn_ver.Text = "Ver dados";
            btn_ver.UseVisualStyleBackColor = true;
            btn_ver.Click += btn_ver_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(194, 138);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 10;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_id;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nome;
        private TextBox txt_salario;
        private ComboBox cb_cargo;
        private GroupBox groupBox1;
        private Button btn_ver;
        private Button btCadastrar;
    }
}
