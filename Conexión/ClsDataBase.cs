using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace Conexión
{
    public class ClsDataBase
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexión"].ToString());
        private SqlConnection connection;
        private SqlTransaction transaction;
        private SqlCommand command;
        
        private void AbrirConexion()
        {
            conexion.Open();
        }
        private void AbrirConexionValidacion()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Conexión"].ToString();
            connection.Open();
        }
        private void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }
        private void CerrarConexionValidacion()
        {
            connection.Close();
            connection.Dispose();
            connection = null;
            GC.Collect();
        }
       
        public DataTable DevolverListado(string query, Hashtable hashtable)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            command = new SqlCommand(query, conexion);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                adapter = new SqlDataAdapter(command);
                if(hashtable != null)
                {
                    foreach(string key in hashtable.Keys)
                    {
                        command.Parameters.AddWithValue(key, hashtable[key]);
                    }
                }
               
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            adapter.Fill(dt);
            return dt;

        }
        public bool Escribir (string query, Hashtable hashtable)
        {
            AbrirConexion();

            try
            {
                transaction = conexion.BeginTransaction();
                command = new SqlCommand (query, conexion, transaction);
                command.CommandType = CommandType.StoredProcedure;

                if(hashtable != null)
                {
                    foreach(string key in hashtable.Keys)
                    {
                        command.Parameters.AddWithValue(key, hashtable[key]);
                    }
                }
                int respuesta = command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (SqlException sql)
            {
                transaction.Rollback();
                return false;
                throw sql;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public bool Scalar (string query, Hashtable hashtable)
        {
            AbrirConexionValidacion();
            command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                if (hashtable != null)
                {
                    foreach (string key in hashtable.Keys)
                    {
                        command.Parameters.AddWithValue(key, hashtable[key]);
                    }
                }
                int respuesta = Convert.ToInt32(command.ExecuteScalar());
                if (respuesta > 0) { return true; }
                else { return false; }
            }
            catch (SqlException sql)
            {
                return false;
                throw sql;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                CerrarConexionValidacion();
            }
        }

    }
}

