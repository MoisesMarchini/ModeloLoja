﻿using ModeloLoja.Users;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ModeloLoja.Scripts
{
    static class Database
    {
        public enum db { usuarios, produtos }
        public static Usuario usuarioLogado { get; set; }
        public static string serverIp = "127.0.0.1";
        public static string strConnection;
        public static MySqlConnection conexao = new MySqlConnection();

        public static DataTable dataTableUsuarios { get; private set; }
        public static DataTable dataTableProdutos { get; private set; }

        public static void ImportDatabase()
        {
            strConnection = "server='" + serverIp + "';User Id=root;password=1234";
            conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS modeloloja";
                comando.ExecuteNonQuery();

                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar ao MySQL \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            ImportTables();
        }

        public static void ImportTables()
        {
            strConnection = "server='" + serverIp + "';User Id=root;database=modeloloja;password=1234";
            conexao.ConnectionString = strConnection;
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE IF NOT EXISTS usuarios ( id INT NOT NULL, nome VARCHAR(50), password VARCHAR(50), saldo DOUBLE, admin BOOL, PRIMARY KEY(id))";
                comando.ExecuteNonQuery();
                dataTableUsuarios = fillDataTable(db.usuarios);
                if (dataTableUsuarios.Rows.Count == 0)
                {
                    comando.CommandText = "INSERT INTO usuarios VALUES (" + 1 + ", 'admin', 'admin'," + 9999 + ", true)";
                    comando.ExecuteNonQuery();
                }
                comando.CommandText = "CREATE TABLE IF NOT EXISTS produtos ( id INT NOT NULL, nome VARCHAR(50), descricao VARCHAR(50), preco DOUBLE, estoque INT, PRIMARY KEY(id))";
                comando.ExecuteNonQuery();
                dataTableProdutos = fillDataTable(db.produtos);

                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar ao servidor \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable fillDataTable(db _db)
        {
            string query = "SELECT * FROM ";
            DataTable dados = new DataTable();
            switch (_db)
            {
                case db.usuarios:
                    query += "usuarios";
                    break;
                case db.produtos:
                    query += "produtos";
                    break;
                default:
                    break;
            }

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

            adaptador.Fill(dados);
            return dados;
        }

        public static bool Logar(Usuario usuario)
        {
            if (usuario.Name == "" || usuario.Password == "")
                return false;

            bool tentativa = false;

            try
            {
                string query = "SELECT * FROM usuarios WHERE nome LIKE '" + usuario.Name + "'";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);
                DataTable dados = new DataTable();

                conexao.Open();

                int results = adaptador.Fill(dados);
                if (results != 0)
                {
                    if (dados.Rows[0][2].ToString() == usuario.Password)
                    {
                        usuarioLogado = new Usuario(usuario.Name, usuario.Password, (double)dados.Rows[0][3], (bool)dados.Rows[0][4]);
                        tentativa = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar ao servidor \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return tentativa;
        }
        public static bool Cadastrar(Usuario usuario)
        {
            if (usuario.Name == "" || usuario.Password == "")
                return false;

            bool tentativa = false;
            usuarioLogado = usuario;

            try
            {
                string query = "SELECT * FROM usuarios WHERE nome LIKE '" + usuarioLogado.Name + "'";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);
                DataTable dados = new DataTable();

                conexao.Open();

                int results = adaptador.Fill(dados);
                if (results != 0)
                {
                    MessageBox.Show("Nome de usuário já cadastrado");
                    return false;
                }


                MySqlCommand comando = new MySqlCommand(strConnection);
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO usuarios VALUES (" + (dataTableUsuarios.Rows.Count+1) + ", '" + usuarioLogado.Name + "', '" + usuarioLogado.Password + "', " + usuarioLogado.Money + ", "+ usuarioLogado.administrador +")";
                comando.ExecuteNonQuery();
                comando.Dispose();

                dataTableUsuarios = fillDataTable(db.usuarios);

                tentativa = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar ao servidor \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return tentativa;
        }

        public static Produto NovoProduto()
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(strConnection);
                comando.Connection = conexao;

                int id = (dataTableProdutos.Rows.Count + 1);
                comando.CommandText = "INSERT INTO produtos VALUES (" + id + ", 'Nome do produto', 'Descricao do produto', " + (double)10 +", " + 20 + ")";
                comando.ExecuteNonQuery();
                comando.Dispose();

                dataTableProdutos = fillDataTable(db.produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar ao servidor \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return new Produto(dataTableProdutos.Rows.Count);
        }
        public static void EditarProduto(Produto produto)
        {
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(strConnection);
                comando.Connection = conexao;

                string query = "UPDATE produtos SET nome = '"+produto.nome+"', descricao = '"+produto.descricao+"', preco="+produto.preco+", estoque="+produto.quantidade+" WHERE id LIKE "+produto.id;


                comando.CommandText = query;
                comando.ExecuteNonQuery();
                comando.Dispose();

                dataTableProdutos = fillDataTable(db.produtos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar ao servidor \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
