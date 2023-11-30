namespace po2PetShop
{
    partial class Cdfuncionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_estcivil = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_estado = new System.Windows.Forms.TextBox();
            this.msk_dtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_celular = new System.Windows.Forms.TextBox();
            this.cb_funcao = new System.Windows.Forms.ComboBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.lb_salario = new System.Windows.Forms.Label();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.lb_salarioo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Location = new System.Drawing.Point(28, 278);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(4);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(209, 15);
            this.tx_nome.TabIndex = 0;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tx_email
            // 
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Location = new System.Drawing.Point(28, 337);
            this.tx_email.Margin = new System.Windows.Forms.Padding(4);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(209, 15);
            this.tx_email.TabIndex = 1;
            this.tx_email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tx_estcivil
            // 
            this.tx_estcivil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_estcivil.Location = new System.Drawing.Point(280, 394);
            this.tx_estcivil.Margin = new System.Windows.Forms.Padding(4);
            this.tx_estcivil.Name = "tx_estcivil";
            this.tx_estcivil.Size = new System.Drawing.Size(211, 15);
            this.tx_estcivil.TabIndex = 8;
            this.tx_estcivil.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // tx_endereco
            // 
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Location = new System.Drawing.Point(280, 457);
            this.tx_endereco.Margin = new System.Windows.Forms.Padding(4);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(211, 15);
            this.tx_endereco.TabIndex = 9;
            this.tx_endereco.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // tx_cidade
            // 
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tx_cidade.Location = new System.Drawing.Point(533, 278);
            this.tx_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(220, 15);
            this.tx_cidade.TabIndex = 10;
            this.tx_cidade.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // tx_estado
            // 
            this.tx_estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_estado.Location = new System.Drawing.Point(533, 337);
            this.tx_estado.Margin = new System.Windows.Forms.Padding(4);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(220, 15);
            this.tx_estado.TabIndex = 11;
            this.tx_estado.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // msk_dtNascimento
            // 
            this.msk_dtNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_dtNascimento.Location = new System.Drawing.Point(280, 337);
            this.msk_dtNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.msk_dtNascimento.Mask = "00/00/0000";
            this.msk_dtNascimento.Name = "msk_dtNascimento";
            this.msk_dtNascimento.Size = new System.Drawing.Size(211, 15);
            this.msk_dtNascimento.TabIndex = 15;
            this.msk_dtNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.msk_dtNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // msk_cpf
            // 
            this.msk_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_cpf.Location = new System.Drawing.Point(40, 457);
            this.msk_cpf.Margin = new System.Windows.Forms.Padding(4);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(183, 15);
            this.msk_cpf.TabIndex = 16;
            this.msk_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // tx_celular
            // 
            this.tx_celular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_celular.Location = new System.Drawing.Point(280, 278);
            this.tx_celular.Margin = new System.Windows.Forms.Padding(4);
            this.tx_celular.Name = "tx_celular";
            this.tx_celular.Size = new System.Drawing.Size(211, 15);
            this.tx_celular.TabIndex = 17;
            // 
            // cb_funcao
            // 
            this.cb_funcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_funcao.FormattingEnabled = true;
            this.cb_funcao.Items.AddRange(new object[] {
            "Administrador",
            "Tosador",
            "Veterinario",
            "Banhista",
            "Funcionario da limpeza",
            "Vendedor",
            "Recepcionista",
            ""});
            this.cb_funcao.Location = new System.Drawing.Point(524, 390);
            this.cb_funcao.Margin = new System.Windows.Forms.Padding(4);
            this.cb_funcao.Name = "cb_funcao";
            this.cb_funcao.Size = new System.Drawing.Size(240, 24);
            this.cb_funcao.TabIndex = 18;
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::po2PetShop.Properties.Resources.bottoclose;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_close.Location = new System.Drawing.Point(924, -6);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(79, 64);
            this.bt_close.TabIndex = 20;
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackgroundImage = global::po2PetShop.Properties.Resources.bottonsave_2;
            this.bt_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_salvar.Location = new System.Drawing.Point(848, 400);
            this.bt_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(155, 128);
            this.bt_salvar.TabIndex = 21;
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // lb_salario
            // 
            this.lb_salario.AutoSize = true;
            this.lb_salario.Location = new System.Drawing.Point(545, 456);
            this.lb_salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_salario.Name = "lb_salario";
            this.lb_salario.Size = new System.Drawing.Size(0, 16);
            this.lb_salario.TabIndex = 22;
            // 
            // tx_rg
            // 
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Location = new System.Drawing.Point(27, 394);
            this.tx_rg.Margin = new System.Windows.Forms.Padding(4);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(211, 15);
            this.tx_rg.TabIndex = 23;
            this.tx_rg.TextChanged += new System.EventHandler(this.tx_rg_TextChanged);
            // 
            // lb_salarioo
            // 
            this.lb_salarioo.AutoSize = true;
            this.lb_salarioo.Location = new System.Drawing.Point(545, 456);
            this.lb_salarioo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_salarioo.Name = "lb_salarioo";
            this.lb_salarioo.Size = new System.Drawing.Size(0, 16);
            this.lb_salarioo.TabIndex = 24;
            // 
            // Cdfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::po2PetShop.Properties.Resources.Frame_1__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 517);
            this.Controls.Add(this.lb_salarioo);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.lb_salario);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.cb_funcao);
            this.Controls.Add(this.tx_celular);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.msk_dtNascimento);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_estcivil);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nome);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cdfuncionario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_estcivil;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.MaskedTextBox msk_dtNascimento;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.TextBox tx_celular;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Label lb_salario;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.Label lb_salarioo;
    }
}

