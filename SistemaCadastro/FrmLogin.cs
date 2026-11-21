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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            if (conecta.verifica(txtuserlogin.Text, txtuserpassword.Text) == true )
            {
                Sistema sistema = new Sistema();
                this.Hide();
                sistema.ShowDialog();
                this.Close();
            }
            else
            { 
                MessageBox.Show("Usuario nao encontrado" + conecta.mensagem);

            
            }
        }

        private void txtuserlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuserpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
