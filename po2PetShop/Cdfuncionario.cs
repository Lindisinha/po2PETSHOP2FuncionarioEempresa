using AppGunaExemplo.Configuracao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace po2PetShop
{
    public partial class Cdfuncionario : Form
    {
        private Funcionario _funcionario;
        public Cdfuncionario()
        {
            InitializeComponent();
            bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_salvar.FlatAppearance.BorderSize = 0;
            bt_salvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_salvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_salvar.BackColor = Color.Transparent;

            bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_close.FlatAppearance.BorderSize = 0;
            bt_close.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_close.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_close.BackColor = Color.Transparent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Validar v = new Validar();
            string cpf = msk_cpf.Text;
            string email=  tx_email.Text;

            double  salario = 0; 

            if (cb_funcao.Text == "Administrador")
            {
                lb_salario.Text = "2500";
                 salario = 2500;

            }
            if (cb_funcao.Text == "Tosador")
            {
                lb_salario.Text = "1200";
                salario = 1200;
            }
            if (cb_funcao.Text == "Veterinario")
            {
                lb_salario.Text = "3000";
                salario = 3000;
            }
            if (cb_funcao.Text == "Banhista")
            {
                lb_salario.Text = "1080";
                salario = 1080;
            }
            if (cb_funcao.Text == "Funcionario da limpeza")
            {
                lb_salario.Text = "1500";
                salario = 1500;
            }
            if (cb_funcao.Text == "Vendedor")
            {
                lb_salario.Text = "1700";
                salario = 1700;
            }
            if (cb_funcao.Text == "Recepcionista")
            {
                lb_salario.Text = "1200";
                salario = 1200;
            }


            if ( v.ValidarCPF(cpf)==false)
            {
                MessageBox.Show("CPF inválido");
            }
            if (v.ValidaEmail(email) == false)
            {
                MessageBox.Show("Email inválido");
            }

            Funcionario f = new Funcionario
            {
                name = tx_nome.Text,
                celular = tx_celular.Text,
                dataNasc = msk_dtNascimento.Text,
                estadoCiv = tx_estcivil.Text,
                endereco = tx_endereco.Text,
                cidade = tx_cidade.Text,
                estado = tx_estado.Text,
                cpf = msk_cpf.Text,
                email = tx_email.Text,
                salario = salario,
                funcao = cb_funcao.SelectedItem.ToString(),
                rg = Convert.ToDouble(tx_rg.Text)
            };

            try
            {
                Inserir(f); 
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inserir(Funcionario _funcionario)
        {
            try
            {
                using (var conexao = new MySqlConnection("server=localHost;uid=root;pwd=root;database=bd_lindsaypo2"))
                {
                    conexao.Open();

                    using (var comando = new MySqlCommand("INSERT INTO Funcionario (name_fun, cpf_fun, rg_fun, email_fun, celular_fun, dtNascimento_fun, estadociv_fun, endereco_fun, cidade_fun, estado_fun, funcao_fun, salario_fun) VALUES (@name, @cpf, @rg, @email, @celular, @dtNascimento, @estadociv, @endereco, @cidade, @estado, @funcao, @salario)", conexao))
                    {
                        string dataFormatada = DateTime.ParseExact(_funcionario.dataNasc, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                        comando.Parameters.AddWithValue("@name", _funcionario.name);
                        comando.Parameters.AddWithValue("@email", _funcionario.email);
                        comando.Parameters.AddWithValue("@cpf", _funcionario.cpf);
                        comando.Parameters.AddWithValue("@rg", _funcionario.rg);
                        comando.Parameters.AddWithValue("@celular", _funcionario.celular);
                        comando.Parameters.AddWithValue("@@dtNascimento", dataFormatada);
                        comando.Parameters.AddWithValue("@estadoCiv", _funcionario.estadoCiv);
                        comando.Parameters.AddWithValue("@endereco", _funcionario.endereco);
                        comando.Parameters.AddWithValue("@cidade", _funcionario.cidade);
                        comando.Parameters.AddWithValue("@estado", _funcionario.estado);
                        comando.Parameters.AddWithValue("@salario", _funcionario.salario);
                        comando.Parameters.AddWithValue("@funcao", _funcionario.funcao);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir funcionário: " + ex.Message);
            }
        }
        private void tx_rg_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
