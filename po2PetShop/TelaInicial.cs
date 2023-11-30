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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btCadastroFuncionario_Click(object sender, EventArgs e)
        {
            Cdfuncionario cb = new Cdfuncionario();
            cb.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inspfuncionario insp = new Inspfuncionario();
            insp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InspEmpresa emp = new InspEmpresa();
            emp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cdempresa ce = new Cdempresa();
            ce.ShowDialog();
        }
    }
}
