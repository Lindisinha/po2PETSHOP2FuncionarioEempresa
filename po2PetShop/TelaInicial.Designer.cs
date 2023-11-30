namespace po2PetShop
{
    partial class TelaInicial
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
            this.btCadastroFuncionario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastroFuncionario
            // 
            this.btCadastroFuncionario.Location = new System.Drawing.Point(571, 314);
            this.btCadastroFuncionario.Name = "btCadastroFuncionario";
            this.btCadastroFuncionario.Size = new System.Drawing.Size(348, 30);
            this.btCadastroFuncionario.TabIndex = 1;
            this.btCadastroFuncionario.Text = "Cadastro Funcionário";
            this.btCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btCadastroFuncionario.Click += new System.EventHandler(this.btCadastroFuncionario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar Funcionário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Consultar Empresa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cadastrar Empresa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::po2PetShop.Properties.Resources.Frame_1__10_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCadastroFuncionario);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaInicial";
            this.Text = "                                                                ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastroFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}