using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace po2PetShop
{
    public partial class Inspfuncionario : Form
    {
        public Inspfuncionario()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (var conexao = new MySqlConnection("server=localHost;uid=root;pwd=root;database=bd_lindsaypo2"))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM funcionario"; 
                    using (var da = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
