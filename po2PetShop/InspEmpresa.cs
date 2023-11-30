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
    public partial class InspEmpresa : Form
    {
        public InspEmpresa()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (var conexao = new MySqlConnection("server=localHost;uid=root;pwd=root;database=bd_lindsaypo2"))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM empresa";
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
