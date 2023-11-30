using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace po2PetShop
{
    public partial class Cdempresa : Form
    {
        private Empresa _empresa;

        public Cdempresa()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            Validar v = new Validar();
            string cpf = msk_cpfP.Text;

            Empresa emp = new Empresa
            {
                nomeFan = tx_nomeFan.Text,
                rzSocial = tx_rzSocial.Text,
                stCadastral = tx_stCadastral.Text,
                cpnj = tx_cnpj.Text,
                telefone = msk_telef.Text,
                dtInicio = msk_dtInicio.Text,
                rgTributario = rd_rgTributario.Text,
                endereco = tx_endereco.Text,
                cidade = tx_cidade1.Text,
                estado = cb_estado1.Text,
                funcao= tx_funcao.Text,
                tipo = rd_tipo.Text,
                ptEmpresa = rd_ptEmpresa.Text,
                ntJuridica = cb_ntJuridica.Text,
                nmProprietario = tx_nmProprietario.Text,
                cpfP = msk_cpfP.Text,

            };

            try

            {
                Inserir(emp);
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inserir(Empresa _empresa)
        {
            try
            {
                using (var conexao = new MySqlConnection("server=localHost;uid=root;pwd=root;database=bd_lindsaypo2"))
                {
                    conexao.Open();


                    using (var comando = new MySqlCommand("INSERT INTO Empresa (nomeFan_emp, rzSocial_emp, stCadastral_emp, cpnj_emp, telefone_emp, dtInicio_emp, rgTributario_emp, endereco_emp, cidade_emp, estado_emp, funcao_emp, tipo_emp, ptEmpresa_emp, ntJuridica_emp, nmProprie_emp, cpfProprie_emp) VALUES (@nomeFan, @rzSocial, @stCadastral, @cpnj, @telefone, @dtInicio, @rgTributario, @endereco, @cidade, @estado, @funcao, @tipo, @ptEmpresa, @ntJuridica, @nmProprietario, @cpfProprietario)", conexao))
                    {
                        string dataFormatada = DateTime.ParseExact(_empresa.dtInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                        comando.Parameters.AddWithValue("@nomeFan", _empresa.nomeFan);
                        comando.Parameters.AddWithValue("@rzSocial", _empresa.rzSocial);
                        comando.Parameters.AddWithValue("@stCadastral", _empresa.stCadastral);
                        comando.Parameters.AddWithValue("@cpnj", _empresa.cpnj);
                        comando.Parameters.AddWithValue("@telefone", _empresa.telefone);
                        comando.Parameters.AddWithValue("@dtInicio", dataFormatada);
                        comando.Parameters.AddWithValue("@rgTributario", _empresa.rgTributario);
                        comando.Parameters.AddWithValue("@endereco", _empresa.endereco);
                        comando.Parameters.AddWithValue("@cidade", _empresa.cidade);
                        comando.Parameters.AddWithValue("@estado", _empresa.estado);
                        comando.Parameters.AddWithValue("@funcao", _empresa.funcao);
                        comando.Parameters.AddWithValue("@tipo", _empresa.tipo);
                        comando.Parameters.AddWithValue("@ptEmpresa", _empresa.ptEmpresa);
                        comando.Parameters.AddWithValue("@ntJuridica", _empresa.ntJuridica);
                        comando.Parameters.AddWithValue("@nmProprietario", _empresa.nmProprietario);
                        comando.Parameters.AddWithValue("@cpfProprietario", _empresa.cpfP);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir Empresa: " + ex.Message);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tx_nFantasia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
