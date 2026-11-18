using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SistemaCadastro
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; user id=root;password=123;database=banco_siscadastro");
        public string mensagem;

        public bool insereAviao(Aviao novoAviao)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereAviao", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("modelo", novoAviao.Modelo);
                cmd.Parameters.AddWithValue("fk_companhia", novoAviao.Companhia);
                cmd.Parameters.AddWithValue("capacidade", novoAviao.Capacidade);
                cmd.Parameters.AddWithValue("anoFabricacao", novoAviao.Fabricacao);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

        public DataTable listaCompanhias()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("sp_listaCompanhias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_generos

        public ConectaBanco()
        {

        }

        public DataTable listaModelos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaAviao", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletaAviao(int idremovebanda)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeAviao", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idavioes", idremovebanda);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alteraAviao(Aviao a, int idaviao)
        {

            MySqlCommand cmd = new MySqlCommand("sp_alteraAviao", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_idaviao", idaviao);
            cmd.Parameters.AddWithValue("p_modelo", a.Modelo);
            cmd.Parameters.AddWithValue("p_capacidade", a.Capacidade);
            cmd.Parameters.AddWithValue("p_anoFabricacao", a.Fabricacao);
            cmd.Parameters.AddWithValue("p_companhia", a.Companhia);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim update_banda

        public bool insereCompanhia(string nomeCompanhia)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereCompanhia", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomeCompanhia", nomeCompanhia);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

        public bool verifica(string user, string pass)
        {
            string senhaHash = BibliotecaHash.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
