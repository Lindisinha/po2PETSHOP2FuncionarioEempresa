namespace po2PetShop
{
    partial class Cdempresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_nFantasia = new System.Windows.Forms.TextBox();
            this.tx_rzSocial = new System.Windows.Forms.TextBox();
            this.tx_cnpj = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cdd = new System.Windows.Forms.TextBox();
            this.tx_funcaoE = new System.Windows.Forms.TextBox();
            this.tx_ptE = new System.Windows.Forms.TextBox();
            this.tx_ntjuridica = new System.Windows.Forms.TextBox();
            this.tx_nomeP = new System.Windows.Forms.TextBox();
            this.msk_cpfP = new System.Windows.Forms.MaskedTextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.bt_sv = new System.Windows.Forms.Button();
            this.msk_telef = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tx_nFantasia
            // 
            this.tx_nFantasia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nFantasia.Location = new System.Drawing.Point(22, 166);
            this.tx_nFantasia.Name = "tx_nFantasia";
            this.tx_nFantasia.Size = new System.Drawing.Size(138, 13);
            this.tx_nFantasia.TabIndex = 0;
            // 
            // tx_rzSocial
            // 
            this.tx_rzSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rzSocial.Location = new System.Drawing.Point(22, 211);
            this.tx_rzSocial.Name = "tx_rzSocial";
            this.tx_rzSocial.Size = new System.Drawing.Size(138, 13);
            this.tx_rzSocial.TabIndex = 1;
            // 
            // tx_cnpj
            // 
            this.tx_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cnpj.Location = new System.Drawing.Point(22, 301);
            this.tx_cnpj.Name = "tx_cnpj";
            this.tx_cnpj.Size = new System.Drawing.Size(138, 13);
            this.tx_cnpj.TabIndex = 3;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Location = new System.Drawing.Point(205, 301);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(147, 13);
            this.tx_endereco.TabIndex = 7;
            // 
            // tx_cdd
            // 
            this.tx_cdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cdd.Location = new System.Drawing.Point(397, 169);
            this.tx_cdd.Name = "tx_cdd";
            this.tx_cdd.Size = new System.Drawing.Size(149, 13);
            this.tx_cdd.TabIndex = 8;
            // 
            // tx_funcaoE
            // 
            this.tx_funcaoE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_funcaoE.Location = new System.Drawing.Point(397, 260);
            this.tx_funcaoE.Name = "tx_funcaoE";
            this.tx_funcaoE.Size = new System.Drawing.Size(149, 13);
            this.tx_funcaoE.TabIndex = 10;
            // 
            // tx_ptE
            // 
            this.tx_ptE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_ptE.Location = new System.Drawing.Point(570, 166);
            this.tx_ptE.Name = "tx_ptE";
            this.tx_ptE.Size = new System.Drawing.Size(153, 13);
            this.tx_ptE.TabIndex = 11;
            // 
            // tx_ntjuridica
            // 
            this.tx_ntjuridica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_ntjuridica.Location = new System.Drawing.Point(570, 216);
            this.tx_ntjuridica.Name = "tx_ntjuridica";
            this.tx_ntjuridica.Size = new System.Drawing.Size(153, 13);
            this.tx_ntjuridica.TabIndex = 12;
            // 
            // tx_nomeP
            // 
            this.tx_nomeP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nomeP.Location = new System.Drawing.Point(570, 258);
            this.tx_nomeP.Name = "tx_nomeP";
            this.tx_nomeP.Size = new System.Drawing.Size(153, 13);
            this.tx_nomeP.TabIndex = 13;
            // 
            // msk_cpfP
            // 
            this.msk_cpfP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_cpfP.Location = new System.Drawing.Point(570, 301);
            this.msk_cpfP.Mask = "000,000,000-00";
            this.msk_cpfP.Name = "msk_cpfP";
            this.msk_cpfP.Size = new System.Drawing.Size(153, 13);
            this.msk_cpfP.TabIndex = 14;
            this.msk_cpfP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.cb_tipo.Location = new System.Drawing.Point(12, 254);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(176, 21);
            this.cb_tipo.TabIndex = 15;
            // 
            // bt_sv
            // 
            this.bt_sv.BackgroundImage = global::po2PetShop.Properties.Resources.bottonsave;
            this.bt_sv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_sv.Location = new System.Drawing.Point(645, 320);
            this.bt_sv.Name = "bt_sv";
            this.bt_sv.Size = new System.Drawing.Size(115, 96);
            this.bt_sv.TabIndex = 16;
            this.bt_sv.UseVisualStyleBackColor = true;
            this.bt_sv.Click += new System.EventHandler(this.button1_Click);
            // 
            // msk_telef
            // 
            this.msk_telef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msk_telef.Location = new System.Drawing.Point(205, 169);
            this.msk_telef.Mask = "(00) 0 0000-0000";
            this.msk_telef.Name = "msk_telef";
            this.msk_telef.Size = new System.Drawing.Size(147, 13);
            this.msk_telef.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(205, 258);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(205, 216);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(147, 13);
            this.maskedTextBox1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.comboBox1.Location = new System.Drawing.Point(383, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(397, 297);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(570, 167);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.comboBox2.Location = new System.Drawing.Point(562, 208);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // Cdempresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::po2PetShop.Properties.Resources.Frame_1__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(735, 403);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.msk_telef);
            this.Controls.Add(this.bt_sv);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.msk_cpfP);
            this.Controls.Add(this.tx_nomeP);
            this.Controls.Add(this.tx_ntjuridica);
            this.Controls.Add(this.tx_ptE);
            this.Controls.Add(this.tx_funcaoE);
            this.Controls.Add(this.tx_cdd);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_cnpj);
            this.Controls.Add(this.tx_rzSocial);
            this.Controls.Add(this.tx_nFantasia);
            this.DoubleBuffered = true;
            this.Name = "Cdempresa";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nFantasia;
        private System.Windows.Forms.TextBox tx_rzSocial;
        private System.Windows.Forms.TextBox tx_cnpj;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_cdd;
        private System.Windows.Forms.TextBox tx_funcaoE;
        private System.Windows.Forms.TextBox tx_ptE;
        private System.Windows.Forms.TextBox tx_ntjuridica;
        private System.Windows.Forms.TextBox tx_nomeP;
        private System.Windows.Forms.MaskedTextBox msk_cpfP;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Button bt_sv;
        private System.Windows.Forms.MaskedTextBox msk_telef;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}