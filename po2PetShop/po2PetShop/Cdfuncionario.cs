using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace po2PetShop
{
    public partial class Cdfuncionario : Form
    {
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mk_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();          

            Validar v = new Validar();
            string cpf = msk_cpf.Text;
            string email=  tx_email.Text;
            string rg1 = tx_rg.Text;
            

            if (cb_funcao.Text == "Administrador")
            {
                lb_salario.Text = "2500";
            }
            if (cb_funcao.Text == "Tosador")
            {
                lb_salario.Text = "1200";
            }
            if (cb_funcao.Text == "Veterinario")
            {
                lb_salario.Text = "3000";
            }
            if (cb_funcao.Text == "Banhista")
            {
                lb_salario.Text = "1080";
            }
            if (cb_funcao.Text == "Funcionario da limpeza")
            {
                lb_salario.Text = "1500";
            }
            if (cb_funcao.Text == "Vendedor")
            {
                lb_salario.Text = "1700";
            }
            if (cb_funcao.Text == "Recepcionista")
            {
                lb_salario.Text = "1200";
            }


            if ( v.ValidarCPF(cpf)==false)
            {
                MessageBox.Show("CPF inválido");
            }
            if (v.ValidaEmail(email) == false)
            {
                MessageBox.Show("Email inválido");
            }
            else 
            {
                MessageBox.Show("Salvo");
            }
        }

        private void tx_rg_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
