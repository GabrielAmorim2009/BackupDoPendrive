namespace Aula_C_
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
            tb_id = new TextBox();
            lb_nome = new Label();
            lb_id = new Label();
            lb_salario = new Label();
            tb_salario = new TextBox();
            tb_nome = new TextBox();
            cb_cargo = new ComboBox();
            lb_cargo = new Label();
            Funcionário = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            Funcionário.SuspendLayout();
            SuspendLayout();
            // 
            // tb_id
            // 
            tb_id.Location = new Point(61, 22);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(152, 23);
            tb_id.TabIndex = 1;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(15, 67);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(40, 15);
            lb_nome.TabIndex = 3;
            lb_nome.Text = "Nome";
            lb_nome.Click += lb_nome_Click;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(37, 25);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(18, 15);
            lb_id.TabIndex = 4;
            lb_id.Text = "ID";
            lb_id.Click += lb_id_Click;
            // 
            // lb_salario
            // 
            lb_salario.AutoSize = true;
            lb_salario.Location = new Point(13, 149);
            lb_salario.Name = "lb_salario";
            lb_salario.Size = new Size(42, 15);
            lb_salario.TabIndex = 5;
            lb_salario.Text = "Salário";
            lb_salario.Click += lb_salario_Click;
            // 
            // tb_salario
            // 
            tb_salario.Location = new Point(61, 146);
            tb_salario.Name = "tb_salario";
            tb_salario.Size = new Size(152, 23);
            tb_salario.TabIndex = 7;
            tb_salario.TextChanged += tb_salario_TextChanged;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(61, 64);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(152, 23);
            tb_nome.TabIndex = 8;
            tb_nome.TextChanged += tb_nome_TextChanged;
            // 
            // cb_cargo
            // 
            cb_cargo.FormattingEnabled = true;
            cb_cargo.Location = new Point(61, 106);
            cb_cargo.Name = "cb_cargo";
            cb_cargo.Size = new Size(152, 23);
            cb_cargo.TabIndex = 9;
            cb_cargo.SelectedIndexChanged += cb_cargo_SelectedIndexChanged;
            // 
            // lb_cargo
            // 
            lb_cargo.AutoSize = true;
            lb_cargo.Location = new Point(15, 109);
            lb_cargo.Name = "lb_cargo";
            lb_cargo.Size = new Size(39, 15);
            lb_cargo.TabIndex = 10;
            lb_cargo.Text = "Cargo";
            lb_cargo.Click += lb_cargo_Click;
            // 
            // Funcionário
            // 
            Funcionário.Controls.Add(button1);
            Funcionário.Controls.Add(tb_id);
            Funcionário.Controls.Add(lb_id);
            Funcionário.Controls.Add(lb_cargo);
            Funcionário.Controls.Add(tb_nome);
            Funcionário.Controls.Add(lb_salario);
            Funcionário.Controls.Add(tb_salario);
            Funcionário.Controls.Add(cb_cargo);
            Funcionário.Controls.Add(lb_nome);
            Funcionário.Location = new Point(355, 268);
            Funcionário.Name = "Funcionário";
            Funcionário.Size = new Size(305, 189);
            Funcionário.TabIndex = 11;
            Funcionário.TabStop = false;
            Funcionário.Text = "Funcionário";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(219, 22);
            button1.Name = "button1";
            button1.Size = new Size(67, 147);
            button1.TabIndex = 11;
            button1.Text = "Ver Dados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(628, 488);
            button2.Name = "button2";
            button2.Size = new Size(117, 85);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 930);
            Controls.Add(button2);
            Controls.Add(Funcionário);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Funcionário.ResumeLayout(false);
            Funcionário.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tb_id;
        private Label lb_nome;
        private Label lb_id;
        private Label lb_salario;
        private TextBox tb_salario;
        private TextBox tb_nome;
        private ComboBox cb_cargo;
        private Label lb_cargo;
        private GroupBox Funcionário;
        private Button button1;
        private Button button2;
    }
}
