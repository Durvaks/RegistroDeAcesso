using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Formats.Asn1;
using CsvHelper;

namespace RegistroDeAcesso
{
    internal class DataBase
    {
        private static string connectionString = "Data Source=" + Directory.GetCurrentDirectory().Replace("\\", "\\\\") + "\\database\\Acess-db.db";

        private static SQLiteConnection ConexaoBanco()
        {
            var conexao = new SQLiteConnection(connectionString);
            conexao.Open();
            return conexao;
        }
        public static DataTable ObterTodosUsuarios()
        {
            DataTable dt = new DataTable();
            using (var conexao = ConexaoBanco())
            using (var cmd = new SQLiteCommand("SELECT * FROM tb_usuarios", conexao))
            {
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static DataTable ObterTodosAcessos()
        {
            using (var conexao = new SQLiteConnection(connectionString))
            {
                using (var cmd = new SQLiteCommand("SELECT * FROM tb_registerAcess", conexao))
                {
                    var da = new SQLiteDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable Consulta(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conexao = ConexaoBanco())
                {
                    using (var cmd = conexao.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        using (var da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }
        public static DataTable Filter(string table, string columnName, string searchValue)
        {
            DataTable tableReturningData = new DataTable();
            try
            {
                using (var connection = ConexaoBanco())
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM " + table + " WHERE " + columnName + " = @searchValue";
                    command.Parameters.AddWithValue("@searchValue", searchValue);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    dataAdapter.Fill(tableReturningData);
                    return tableReturningData;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }
        public static void CadastrarUsuario(string produtivo, string nome, string senha)
        {
            try
            {
                using var conn = ConexaoBanco();
                using var cmd = conn.CreateCommand();
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                string NomeFormatado = ti.ToTitleCase(nome);
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_PRODUTIVO, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@NomeFormatado, @produtivo, @senha, 'Ativo', 0)";
                cmd.Parameters.AddWithValue("@NomeFormatado", NomeFormatado);
                cmd.Parameters.AddWithValue("@produtivo", produtivo);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void AlterarDadosDoUsuario(string produtivo, string coluna, string novainformacao)
        {
            try
            {
                using var conexao = ConexaoBanco();
                using var cmd = conexao.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET " + coluna + " = @novainformacao WHERE T_PRODUTIVO = @produtivo";
                cmd.Parameters.AddWithValue("@novainformacao", novainformacao);
                cmd.Parameters.AddWithValue("@produtivo", produtivo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void RemoverUsuario(string produtivo)
        {
            try
            {
                using var cmd = ConexaoBanco().CreateCommand();
                {
                    cmd.CommandText = "DELETE FROM tb_usuarios WHERE T_PRODUTIVO = "+produtivo;
                    new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable EncontrarUsuario(string produtivo) 
        { 
            DataTable tableReturningData = new DataTable();
            try
            {
                using (var connection = ConexaoBanco())
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM tb_usuarios WHERE T_PRODUTIVO = @searchValue";
                    command.Parameters.AddWithValue("@searchValue", produtivo);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    dataAdapter.Fill(tableReturningData);
                    return tableReturningData;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }
        public static void RegisterAccess(string produtivo, string nomeDoColaborador, string dataDoRegistro, string horaDoRegistro)
        {
            try
            {
                using var conn = ConexaoBanco();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_registerAcess (PRODUTIVO, NOMEDOCOLABORADOR, DATADOREGISTRO, HORADOREGISTRO) VALUES (@produtivo, @nomeDoColaborador, @dataDoRegistro, @horaDoRegistro)";
                cmd.Parameters.AddWithValue("@produtivo", produtivo);
                cmd.Parameters.AddWithValue("@nomeDoColaborador", nomeDoColaborador);
                cmd.Parameters.AddWithValue("@dataDoRegistro", dataDoRegistro);
                cmd.Parameters.AddWithValue("@horaDoRegistro", horaDoRegistro);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void RemoverAcesso(int index) 
        {            
            try
            {
                using var cmd = ConexaoBanco().CreateCommand();
                {
                    cmd.CommandText = "DELETE FROM tb_registerAcess WHERE `INDEX` = " + index.ToString();
                    new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }
        public static DataTable VerificarDuplicidade(string produtivo) 
        {
            DataTable tableReturningData = new DataTable();
            var today = DateTime.Now;
            string thisDay = today.ToString("dd/mm/yyyy");
            try
            {
                using (var connection = ConexaoBanco())
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM tb_registerAcess WHERE PRODUTIVO = @usercode AND DATADOREGISTRO = @thisday";
                    command.Parameters.AddWithValue("@usercode", produtivo);
                    command.Parameters.AddWithValue("@thisday", thisDay);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    dataAdapter.Fill(tableReturningData);
                    return tableReturningData;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBanco().Close();
            }
        }

        public static void CadastrarColaborador(string Produtivo, string Nome, string sector)
        {
            try
            {
                using var conn = ConexaoBanco();
                using var cmd = conn.CreateCommand();
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                string NomeFormatado = ti.ToTitleCase(Nome);
                cmd.CommandText = "INSERT INTO tb_colaboradores (T_PRODUTIVO, T_NAME, T_SECTOR) VALUES (@produtivo, @NomeFormatado, @Sector)";
                cmd.Parameters.AddWithValue("@NomeFormatado", NomeFormatado);
                cmd.Parameters.AddWithValue("@produtivo", Produtivo);
                cmd.Parameters.AddWithValue("@Sector", sector);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ImportarUsuarios(string caminhoArquivo)
        {
            using (var reader = new StreamReader(caminhoArquivo))
            using (var csv = new CsvReader(reader, new CultureInfo("pt-BR", true)))
            {
                var registros = csv.GetRecords<Colaborador>();
                using var conexao = ConexaoBanco();
                using var cmd = conexao.CreateCommand();

                foreach (var registro in registros)
                {
                    cmd.CommandText = $"INSERT INTO tb_colaboradores (T_PRODUTIVO, T_NAME, T_SECTOR) VALUES ('{registro.T_PRODUTIVO}', '{registro.T_NAME}', '{registro.T_SECTOR}')";
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.ErrorCode == 19) // "UNIQUE constraint failed"
                        {
                            // Registro já existe, ignorar e continuar para o próximo
                            continue;
                        }
                        throw ex;
                    }
                }
            }
        }
    }
    public class Colaborador
    {
        public string T_PRODUTIVO { get; set; }
        public string T_NAME { get; set; }
        public string T_SECTOR { get; set; }
    }
}



