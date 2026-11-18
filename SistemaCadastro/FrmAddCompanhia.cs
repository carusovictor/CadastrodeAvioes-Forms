using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmAddCompanhia : Form
    {
        public FrmAddCompanhia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
           
            bool retorno = con.insereCompanhia(txtaddcompanhia.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Companhia adicionada com sucesso!");

            txtaddcompanhia.Clear();
            txtaddcompanhia.Focus();    
        }

        private void lblmodelo_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Sistema formSistema = new Sistema();
            
            this.Close();
            formSistema.Show();
        }
    }
}
