using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

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
    }
}
