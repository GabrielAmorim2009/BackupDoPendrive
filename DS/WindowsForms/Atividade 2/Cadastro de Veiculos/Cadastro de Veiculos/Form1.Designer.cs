namespace Cadastro_de_Veiculos
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
            TxtTitulo = new Label();
            GboxDados = new GroupBox();
            btnlimparcarro = new Button();
            btncarregarcarro = new Button();
            pictureBox1 = new PictureBox();
            cbestadocarro = new ComboBox();
            label7 = new Label();
            cbfabricante = new ComboBox();
            cbano = new ComboBox();
            txtcidadecarro = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtcor = new TextBox();
            label4 = new Label();
            txtplaca = new TextBox();
            txtmodelo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            btncarregarpessoa = new Button();
            btnlimparpessoa = new Button();
            pictureBox2 = new PictureBox();
            label15 = new Label();
            txtcpf = new TextBox();
            label14 = new Label();
            txtrg = new TextBox();
            label13 = new Label();
            cbestadopessoa = new ComboBox();
            label12 = new Label();
            txtcomplemento = new TextBox();
            label10 = new Label();
            txtbairro = new TextBox();
            label11 = new Label();
            txtenderecopessoa = new TextBox();
            label9 = new Label();
            txtnomepessoa = new TextBox();
            label8 = new Label();
            GboxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTitulo.Location = new Point(615, 9);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(383, 50);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.Text = "Cadastro de Veículos";
            // 
            // GboxDados
            // 
            GboxDados.Controls.Add(btnlimparcarro);
            GboxDados.Controls.Add(btncarregarcarro);
            GboxDados.Controls.Add(pictureBox1);
            GboxDados.Controls.Add(cbestadocarro);
            GboxDados.Controls.Add(label7);
            GboxDados.Controls.Add(cbfabricante);
            GboxDados.Controls.Add(cbano);
            GboxDados.Controls.Add(txtcidadecarro);
            GboxDados.Controls.Add(label6);
            GboxDados.Controls.Add(label5);
            GboxDados.Controls.Add(txtcor);
            GboxDados.Controls.Add(label4);
            GboxDados.Controls.Add(txtplaca);
            GboxDados.Controls.Add(txtmodelo);
            GboxDados.Controls.Add(label3);
            GboxDados.Controls.Add(label2);
            GboxDados.Controls.Add(label1);
            GboxDados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GboxDados.Location = new Point(16, 74);
            GboxDados.Name = "GboxDados";
            GboxDados.Size = new Size(784, 468);
            GboxDados.TabIndex = 1;
            GboxDados.TabStop = false;
            GboxDados.Text = "Dados Veículo";
            GboxDados.Enter += GboxDados_Enter;
            // 
            // btnlimparcarro
            // 
            btnlimparcarro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimparcarro.Location = new Point(613, 350);
            btnlimparcarro.Name = "btnlimparcarro";
            btnlimparcarro.Size = new Size(141, 51);
            btnlimparcarro.TabIndex = 16;
            btnlimparcarro.Text = "Limpar";
            btnlimparcarro.UseVisualStyleBackColor = true;
            btnlimparcarro.Click += btnlimparcarro_Click;
            // 
            // btncarregarcarro
            // 
            btncarregarcarro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncarregarcarro.Location = new Point(464, 350);
            btncarregarcarro.Name = "btncarregarcarro";
            btncarregarcarro.Size = new Size(143, 51);
            btncarregarcarro.TabIndex = 7;
            btncarregarcarro.Text = "Carregar";
            btncarregarcarro.UseVisualStyleBackColor = true;
            btncarregarcarro.Click += btncarregarcarro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(464, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 290);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cbestadocarro
            // 
            cbestadocarro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestadocarro.FormattingEnabled = true;
            cbestadocarro.Location = new Point(83, 269);
            cbestadocarro.Name = "cbestadocarro";
            cbestadocarro.Size = new Size(375, 33);
            cbestadocarro.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 184);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 13;
            label7.Text = "Fabricante";
            // 
            // cbfabricante
            // 
            cbfabricante.DropDownStyle = ComboBoxStyle.DropDownList;
            cbfabricante.FormattingEnabled = true;
            cbfabricante.Location = new Point(118, 181);
            cbfabricante.Name = "cbfabricante";
            cbfabricante.Size = new Size(340, 33);
            cbfabricante.TabIndex = 12;
            cbfabricante.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cbano
            // 
            cbano.DropDownStyle = ComboBoxStyle.DropDownList;
            cbano.FormattingEnabled = true;
            cbano.Location = new Point(59, 96);
            cbano.Name = "cbano";
            cbano.Size = new Size(399, 33);
            cbano.TabIndex = 11;
            cbano.SelectedIndexChanged += cbano_SelectedIndexChanged;
            // 
            // txtcidadecarro
            // 
            txtcidadecarro.Location = new Point(83, 311);
            txtcidadecarro.Name = "txtcidadecarro";
            txtcidadecarro.Size = new Size(375, 33);
            txtcidadecarro.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 314);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 9;
            label6.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 269);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 7;
            label5.Text = "Estado";
            // 
            // txtcor
            // 
            txtcor.Location = new Point(59, 226);
            txtcor.Name = "txtcor";
            txtcor.Size = new Size(399, 33);
            txtcor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 226);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 5;
            label4.Text = "Cor";
            // 
            // txtplaca
            // 
            txtplaca.Location = new Point(69, 138);
            txtplaca.Name = "txtplaca";
            txtplaca.Size = new Size(389, 33);
            txtplaca.TabIndex = 4;
            // 
            // txtmodelo
            // 
            txtmodelo.Location = new Point(90, 54);
            txtmodelo.Name = "txtmodelo";
            txtmodelo.Size = new Size(368, 33);
            txtmodelo.TabIndex = 3;
            txtmodelo.TextChanged += txtmodelo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 99);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 1;
            label2.Text = "Ano";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Modelo";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 548);
            button1.Name = "button1";
            button1.Size = new Size(225, 77);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(468, 548);
            button3.Name = "button3";
            button3.Size = new Size(225, 77);
            button3.TabIndex = 3;
            button3.Text = "Consultar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1368, 548);
            button4.Name = "button4";
            button4.Size = new Size(225, 77);
            button4.TabIndex = 6;
            button4.Text = "Sair";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(938, 548);
            button5.Name = "button5";
            button5.Size = new Size(225, 77);
            button5.TabIndex = 5;
            button5.Text = "Limpar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btncarregarpessoa);
            groupBox1.Controls.Add(btnlimparpessoa);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtcpf);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtrg);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cbestadopessoa);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtcomplemento);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtbairro);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtenderecopessoa);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtnomepessoa);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(806, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 468);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Proprietário";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(172, 348);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(378, 27);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(344, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 75);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(119, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Outro";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(10, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(383, 56);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "1º Veiculo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btncarregarpessoa
            // 
            btncarregarpessoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncarregarpessoa.Location = new Point(562, 269);
            btncarregarpessoa.Name = "btncarregarpessoa";
            btncarregarpessoa.Size = new Size(204, 45);
            btncarregarpessoa.TabIndex = 17;
            btncarregarpessoa.Text = "Carregar";
            btncarregarpessoa.UseVisualStyleBackColor = true;
            btncarregarpessoa.Click += btncarregarpessoa_Click;
            // 
            // btnlimparpessoa
            // 
            btnlimparpessoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimparpessoa.Location = new Point(562, 320);
            btnlimparpessoa.Name = "btnlimparpessoa";
            btnlimparpessoa.Size = new Size(204, 53);
            btnlimparpessoa.TabIndex = 17;
            btnlimparpessoa.Text = "Limpar";
            btnlimparpessoa.UseVisualStyleBackColor = true;
            btnlimparpessoa.Click += btnlimparpessoa_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Location = new Point(562, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 205);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(16, 348);
            label15.Name = "label15";
            label15.Size = new Size(161, 25);
            label15.TabIndex = 26;
            label15.Text = "Data Nascimento";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(67, 306);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(483, 33);
            txtcpf.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 309);
            label14.Name = "label14";
            label14.Size = new Size(45, 25);
            label14.TabIndex = 24;
            label14.Text = "CPF";
            label14.Click += label14_Click;
            // 
            // txtrg
            // 
            txtrg.Location = new Point(59, 264);
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(491, 33);
            txtrg.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(16, 267);
            label13.Name = "label13";
            label13.Size = new Size(37, 25);
            label13.TabIndex = 22;
            label13.Text = "RG";
            // 
            // cbestadopessoa
            // 
            cbestadopessoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestadopessoa.FormattingEnabled = true;
            cbestadopessoa.Location = new Point(81, 225);
            cbestadopessoa.Name = "cbestadopessoa";
            cbestadopessoa.Size = new Size(469, 33);
            cbestadopessoa.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 228);
            label12.Name = "label12";
            label12.Size = new Size(69, 25);
            label12.TabIndex = 14;
            label12.Text = "Estado";
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(147, 186);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(403, 33);
            txtcomplemento.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 189);
            label10.Name = "label10";
            label10.Size = new Size(134, 25);
            label10.TabIndex = 20;
            label10.Text = "Complemento";
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(100, 141);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(238, 33);
            txtbairro.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(16, 144);
            label11.Name = "label11";
            label11.Size = new Size(63, 25);
            label11.TabIndex = 18;
            label11.Text = "Bairro";
            // 
            // txtenderecopessoa
            // 
            txtenderecopessoa.Location = new Point(100, 99);
            txtenderecopessoa.Name = "txtenderecopessoa";
            txtenderecopessoa.Size = new Size(238, 33);
            txtenderecopessoa.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 102);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 16;
            label9.Text = "Endereço";
            // 
            // txtnomepessoa
            // 
            txtnomepessoa.Location = new Point(100, 54);
            txtnomepessoa.Name = "txtnomepessoa";
            txtnomepessoa.Size = new Size(238, 33);
            txtnomepessoa.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 57);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 14;
            label8.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 637);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(GboxDados);
            Controls.Add(TxtTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            GboxDados.ResumeLayout(false);
            GboxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtTitulo;
        private GroupBox GboxDados;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label7;
        private ComboBox cbfabricante;
        private ComboBox cbano;
        private TextBox txtcidadecarro;
        private Label label6;
        private Label label5;
        private TextBox txtcor;
        private Label label4;
        private TextBox txtplaca;
        private TextBox txtmodelo;
        private Label label15;
        private TextBox txtcpf;
        private Label label14;
        private TextBox txtrg;
        private Label label13;
        private ComboBox cbestadopessoa;
        private Label label12;
        private TextBox txtcomplemento;
        private Label label10;
        private TextBox txtbairro;
        private Label label11;
        private TextBox txtenderecopessoa;
        private Label label9;
        private TextBox txtnomepessoa;
        private Label label8;
        private PictureBox pictureBox1;
        private ComboBox cbestadocarro;
        private PictureBox pictureBox2;
        private Button btnlimparcarro;
        private Button btncarregarcarro;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private Button btncarregarpessoa;
        private Button btnlimparpessoa;
        private DateTimePicker dateTimePicker1;
    }
}
