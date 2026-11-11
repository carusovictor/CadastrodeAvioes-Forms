using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {

        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }






        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgModelos.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("modelo like '{0}%'", txtBusca.Text);
        }

        private void btnRemoveModelo_Click(object sender, EventArgs e)
        {
            int linha = dgModelos.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgModelos.Rows[linha].Cells["idaviao"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Avião", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaAviao(id);
                if (retorno == true)
                {
                    MessageBox.Show("Avião excluido com sucesso!");
                    listagridModelos();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
           


        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Aviao novoAviao = new Aviao();
            novoAviao.Modelo = txtmodelo.Text;
            novoAviao.Capacidade = Convert.ToInt32(txtcapacidade.Text);
            novoAviao.Fabricacao = Convert.ToInt32(txtfabricacao.Text);
            novoAviao.Companhia = Convert.ToInt32( cbCompanhia.SelectedValue.ToString() );
            bool retorno = con.insereAviao(novoAviao);
            if (retorno == false)
                MessageBox.Show(con.mensagem);

            limpaCampos();
            listagridModelos();
            
            
        }

        void limpaCampos()
        {
            txtmodelo.Clear();
            cbCompanhia.Text = "";
            txtcapacidade.Clear();
            txtfabricacao.Clear();
            txtmodelo.Focus();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBCompanhias();
            listagridModelos();
        }

        private void listagridModelos()
        { 
            ConectaBanco con = new ConectaBanco();
            dgModelos.DataSource = con.listaModelos();
            dgModelos.Columns["idaviao"].Visible = false;
        }


        public void listaCBCompanhias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCompanhias();
            cbCompanhia.DataSource = tabelaDados;
            cbCompanhia.DisplayMember = "companhia";
            cbCompanhia.ValueMember = "idcompanhia";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
