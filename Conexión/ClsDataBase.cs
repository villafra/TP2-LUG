using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Conexión
{
    public class ClsDataBase
    {
        private SqlConnection conexion;
        
        public void AbrirConexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["Conexión"].ToString();
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

        public DataSet DevolverListado(string query)
        {
            AbrirConexion();
            DataSet Ds = new DataSet();
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter(query, conexion);
                DataAdapter.Fill(Ds);
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return Ds;
        }


        public int Cantidades(string query)
        {
            int cantidad = 0;
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = conexion;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        cantidad = Convert.ToInt32(reader[0]);
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
            finally
            {
                CerrarConexion();
            }
            return cantidad;

        }

        public bool LeerScalar(string query)
        {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool EscribirTransaction(string query)
        {
            AbrirConexion();
            SqlTransaction sqlTransaction;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = query;
            sqlTransaction = conexion.BeginTransaction();

            try
            {
                cmd.Transaction = sqlTransaction;
                cmd.ExecuteNonQuery();
                sqlTransaction.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool EscribirTransaction(string[] query)
        {
            AbrirConexion();
            SqlTransaction sqlTransaction;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            sqlTransaction = conexion.BeginTransaction();

            try
            {
                for (int i = 0; i < query.Length; i++)
                {
                    cmd.CommandText = query[i];
                    cmd.Transaction = sqlTransaction;
                    cmd.ExecuteNonQuery();
                }

                sqlTransaction.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}

