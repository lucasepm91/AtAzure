using ApiPaises.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPaises.Repository
{
    public class LocalidadeRepository
    {
        string connectionString = "Server = tcp:atwcfazurelucas.database.windows.net,1433;Initial Catalog = AtAzureLucasEd; Persist Security Info=False;User ID = lucas; Password=Azure*At*WCF; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        public List<Pais> BuscarPaises()
        {
            List<Pais> paises = new List<Pais>();

            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "BuscarPaises";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pais pais = new Pais();
                            pais.Id = (int)reader["Id"];
                            pais.Nome = reader["Nome"].ToString();
                            pais.Bandeira = reader["Bandeira"].ToString();                            
                            paises.Add(pais);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return paises;

        }

        public Pais BuscarPais(int id)
        {
            Pais pais = null;
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "BuscarPais";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", id);
                try
                {
                    connection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                pais = new Pais();
                                pais.Id = (int)reader["Id"];
                                pais.Nome = reader["Nome"].ToString();
                                pais.Bandeira = reader["Bandeira"].ToString();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return pais;
        }

        public void AtualizarPais(int id, Pais pais)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "AtualizarPais";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.AddWithValue("@Nome", pais.Nome);
                sqlCommand.Parameters.AddWithValue("@Bandeira", pais.Bandeira);                

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void CriarPais(Pais pais)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "CriarPais";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                
                sqlCommand.Parameters.AddWithValue("@Nome", pais.Nome);
                sqlCommand.Parameters.AddWithValue("@Bandeira", pais.Bandeira);                             

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeletarPais(int id)
        {
            Pais pais = BuscarPais(id);
            DeletarEstadosDoPais(pais.Nome);

            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "DeletarPais";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Estado> BuscarEstados()
        {
            List<Estado> estados = new List<Estado>();

            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "BuscarEstados";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estado estado = new Estado();
                            estado.Id = (int)reader["Id"];
                            estado.Nome = reader["Nome"].ToString();
                            estado.Bandeira = reader["Bandeira"].ToString();
                            estado.Pais = reader["Pais"].ToString();
                            estados.Add(estado);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return estados;

        }

        public Estado BuscarEstado(int id)
        {
            Estado estado = null;
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "BuscarEstado";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", id);
                try
                {
                    connection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                estado = new Estado();
                                estado.Id = (int)reader["Id"];
                                estado.Nome = reader["Nome"].ToString();
                                estado.Bandeira = reader["Bandeira"].ToString();
                                estado.Pais = reader["Pais"].ToString();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return estado;
        }

        public void AtualizarEstado(int id, Estado estado)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "AtualizarEstado";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.AddWithValue("@Nome", estado.Nome);
                sqlCommand.Parameters.AddWithValue("@Bandeira", estado.Bandeira);
                sqlCommand.Parameters.AddWithValue("@Pais", estado.Pais);

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void CriarEstado(Estado estado)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "CriarEstado";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Nome", estado.Nome);
                sqlCommand.Parameters.AddWithValue("@Bandeira", estado.Bandeira);
                sqlCommand.Parameters.AddWithValue("@Pais", estado.Pais);

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeletarEstado(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "DeletarEstado";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Estado> BuscarEstadosDoPais(string pais)
        {
            List<Estado> estados = new List<Estado>();

            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "BuscarEstadosPais";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Pais", pais);

                try
                {
                    connection.Open();

                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estado estado = new Estado();
                            estado.Id = (int)reader["Id"];
                            estado.Nome = reader["Nome"].ToString();
                            estado.Bandeira = reader["Bandeira"].ToString();
                            estado.Pais = reader["Pais"].ToString();
                            estados.Add(estado);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return estados;

        }

        private void DeletarEstadosDoPais(string pais)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "DeletarEstadosRelacionados";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Pais", pais);

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
