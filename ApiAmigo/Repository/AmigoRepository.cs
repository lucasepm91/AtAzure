using ApiAmigo.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAmigo.Repository
{
    public class AmigoRepository
    {
        string connectionString = "Server = tcp:atwcfazurelucas.database.windows.net,1433;Initial Catalog = AtAzureLucasEd; Persist Security Info=False;User ID = lucas; Password=Azure*At*WCF; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

    public List<Amigo> BuscarAmigos()
        {
            List<Amigo> amigos = new List<Amigo>();

            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "BuscarAmigos";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    connection.Open();

                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Amigo amigo = new Amigo();
                            amigo.Id = (int)reader["Id"];
                            amigo.Nome = reader["Nome"].ToString();
                            amigo.Sobrenome = reader["Sobrenome"].ToString();
                            amigo.Email = reader["Email"].ToString();
                            amigo.Telefone = reader["Telefone"].ToString();
                            amigo.DataNascimento = (DateTime)reader["DataNascimento"];
                            amigo.Foto = reader["Foto"].ToString();
                            amigo.EstadoOrigem = reader["EstadoOrigem"].ToString();
                            amigo.PaisOrigem = reader["PaisOrigem"].ToString();
                            amigos.Add(amigo);
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

            return amigos;
        
    }

        public Amigo BuscarAmigo(int id)
        {
            Amigo amigo = null;
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "BuscarAmigo";
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
                                amigo = new Amigo();
                                amigo.Id = (int)reader["Id"];
                                amigo.Nome = reader["Nome"].ToString();
                                amigo.Sobrenome = reader["Sobrenome"].ToString();
                                amigo.Email = reader["Email"].ToString();
                                amigo.Telefone = reader["Telefone"].ToString();
                                amigo.DataNascimento = (DateTime)reader["DataNascimento"];
                                amigo.Foto = reader["Foto"].ToString();
                                amigo.EstadoOrigem = reader["EstadoOrigem"].ToString();
                                amigo.PaisOrigem = reader["PaisOrigem"].ToString();
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

            return amigo;
        }

        public void AtualizarAmigo(int id, Amigo amigo)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "AtualizarAmigo";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.Parameters.AddWithValue("@Nome", amigo.Nome);
                sqlCommand.Parameters.AddWithValue("@Sobrenome", amigo.Sobrenome);
                sqlCommand.Parameters.AddWithValue("@Email", amigo.Email);
                sqlCommand.Parameters.AddWithValue("@Telefone", amigo.Telefone);
                sqlCommand.Parameters.AddWithValue("@DataNascimento", amigo.DataNascimento);
                sqlCommand.Parameters.AddWithValue("@Foto", amigo.Foto);
                sqlCommand.Parameters.AddWithValue("@PaisOrigem", amigo.PaisOrigem);
                sqlCommand.Parameters.AddWithValue("@EstadoOrigem", amigo.EstadoOrigem);

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

        public void CriarAmigo(Amigo amigo)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "CriarAmigo";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Nome", amigo.Nome);
                sqlCommand.Parameters.AddWithValue("@Sobrenome", amigo.Sobrenome);
                sqlCommand.Parameters.AddWithValue("@Email", amigo.Email);
                sqlCommand.Parameters.AddWithValue("@Telefone", amigo.Telefone);
                sqlCommand.Parameters.AddWithValue("@DataNascimento", amigo.DataNascimento);
                sqlCommand.Parameters.AddWithValue("@Foto", amigo.Foto);
                sqlCommand.Parameters.AddWithValue("@PaisOrigem", amigo.PaisOrigem);
                sqlCommand.Parameters.AddWithValue("@EstadoOrigem", amigo.EstadoOrigem);

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

        public void DeletarAmigo(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var procedureName = "DeletarAmigo";
                var sqlCommand = new SqlCommand(procedureName, connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    var linhas = sqlCommand.ExecuteNonQuery();
                }
                catch(Exception e)
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
