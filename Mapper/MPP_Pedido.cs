using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;
using System.Data;

namespace Mapper
{
    public class MPP_Pedido : IGestionable<BE_Pedido>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Pedido oBE_Pedido)
        {
            string[] query = new string[2];
            query[0] = @"update Pedido set Activo = 0, Cancelado = 1 where Codigo_Pedido = " + oBE_Pedido.Codigo;
            query[1] = @"update Mesa set Estado='Disponible', CantidadComensales=0 where Nro_Mesa= " + oBE_Pedido.CodigoMesa.Codigo;
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public bool Guardar(BE_Pedido oBE_Pedido)
        {
            string[] query = new string[2];
            query[0] = @"update Pedido set Activo = 0 where Codigo_Pedido = " + oBE_Pedido.Codigo;
            query[1] = @"update Mesa set Estado='Disponible', CantidadComensales=0 where Nro_Mesa= " + oBE_Pedido.CodigoMesa.Codigo;
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public List<BE_Pedido> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Pedido where Activo= 1";
            Ds = Acceso.DevolverListado(query);
            List<BE_Pedido> ListadePedidos = new List<BE_Pedido>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Pedido Pedido = new BE_Pedido();
                    Pedido.Codigo = Convert.ToInt32(row[0].ToString());
                    Pedido.FechaHoradeInicio = Convert.ToDateTime(row[3].ToString());
                    if (!(row[4] is DBNull))
                    {
                        Pedido.Observaciones = row[4].ToString();
                    }
                    else
                    {
                        Pedido.Observaciones = null;
                    }
                    Pedido.Monto = Convert.ToDecimal(row[5].ToString());
                    Pedido.Activo = Convert.ToBoolean(row[6].ToString());
                    Pedido.Cancelado = Convert.ToBoolean(row[7].ToString());
                    if (!(row[1] is DBNull))
                    {
                        DataSet Ds1;
                        string query1 = @"select * from Mesa where Mesa.Id_Mesa= " + Convert.ToInt32(row[1].ToString());
                        Ds1 = Acceso.DevolverListado(query1);
                        if (Ds1.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow row1 in Ds1.Tables[0].Rows)
                            {
                                BE_Mesa Mesa = new BE_Mesa();
                                Mesa.Codigo = Convert.ToInt32(row1[0].ToString());
                                Mesa.NroDeMesa = Convert.ToInt32(row1[1].ToString());
                                Mesa.Capacidad = Convert.ToInt32(row1[2].ToString());
                                Mesa.Estado = row1[3].ToString();
                                Mesa.CantidadComensales = Convert.ToInt32(row1[4].ToString());
                                Pedido.CodigoMesa = Mesa;
                            }
                        }

                    }
                    if (!(row[2] is DBNull))
                    {
                        DataSet Ds2;
                        string query2 = @"Select * from Mozo,Turno where Mozo.Codigo_Turno=Turno.Codigo_Turno and Mozo.Legajo= " + Convert.ToInt32(row[2].ToString());
                        Ds2 = Acceso.DevolverListado(query2);
                        if(Ds2.Tables[0].Rows.Count > 0)
                        {
                            foreach(DataRow row2 in Ds2.Tables[0].Rows)
                            {
                                BE_Mozo Mozo = new BE_Mozo();
                                Mozo.Codigo = Convert.ToInt32(row2[0].ToString());
                                Mozo.DNI = Convert.ToInt32(row2[1].ToString());
                                Mozo.Nombre = row2[2].ToString();
                                Mozo.Apellido = row2[3].ToString();
                                Mozo.FechaNacimiento = Convert.ToDateTime(row2[4].ToString());
                                Mozo.Edad = Mozo.DevolverEdad();
                                BE_Turno oBE_Turno = new BE_Turno();
                                oBE_Turno.Codigo = Convert.ToInt32(row2[7].ToString());
                                oBE_Turno.NombreTurno = row2[8].ToString();
                                oBE_Turno.HoraInicio = Convert.ToDateTime(row2[9].ToString());
                                oBE_Turno.HoraFin = Convert.ToDateTime(row2[10].ToString());
                                Mozo.Turno = oBE_Turno;
                                Pedido.CodigoMozo = Mozo;
                            }
                        }
                    }
                    DataSet Ds3;
                    string query3 = @"Select * from Plato,Pedido, Pedido_Plato where Pedido.Codigo_Pedido=Pedido_Plato.Codigo_Pedido and Pedido_Plato.Codigo_Plato=Plato.Codigo_Plato and Pedido.Codigo_Pedido= " + Pedido.Codigo;
                    Ds3 = Acceso.DevolverListado(query3);
                    if (Ds3.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row3 in Ds3.Tables[0].Rows)
                        {
                            BE_Plato Plato = new BE_Plato();
                            Plato.Codigo = Convert.ToInt32(row3[0].ToString());
                            Plato.Nombre = row3[1].ToString();
                            Plato.Tipo = row3[2].ToString();
                            Plato.Clase = row3[3].ToString();
                            if (!(row3[4] is DBNull))
                            { Plato.Stock = Convert.ToInt32(row3[4].ToString()); }
                            else { Plato.Stock = 0; }
                            Plato.CostoUnitario = Convert.ToDecimal(row3[5].ToString());
                            Pedido.Platos.Add(Plato);
                        }
                    }
                    DataSet Ds4;
                    string query4 = @"Select * from Bebida,Pedido, Pedido_Bebida where Pedido.Codigo_Pedido=Pedido_Bebida.Codigo_Pedido and Pedido_Bebida.Codigo_Bebida=Bebida.Codigo_Bebida and Pedido.Codigo_Pedido= " + Pedido.Codigo;
                    Ds4 = Acceso.DevolverListado(query4);
                    if (Ds4.Tables[0].Rows.Count > 0)
                    {
                        foreach(DataRow row4 in Ds4.Tables[0].Rows)
                        {
                            BE_Bebida Bebida = new BE_Bebida();
                            BE_Bebida_Alcohólica Bebida_Alcohólica = new BE_Bebida_Alcohólica();
                            if (row4[6].ToString() == "")
                            {
                                Bebida.Codigo = Convert.ToInt32(row4[0].ToString());
                                Bebida.Nombre = row4[1].ToString();
                                Bebida.Tipo = row4[2].ToString();
                                Bebida.Presentación = row4[3].ToString();
                                Bebida.CostoUnitario = Convert.ToDecimal(row4[4].ToString());
                                Bebida.Stock = Convert.ToInt32(row4[5].ToString());
                                Pedido.Bebidas.Add(Bebida);
                            }
                            else
                            {
                                Bebida_Alcohólica.Codigo = Convert.ToInt32(row4[0].ToString());
                                Bebida_Alcohólica.Nombre = row4[1].ToString();
                                Bebida_Alcohólica.Tipo = row4[2].ToString();
                                Bebida_Alcohólica.Presentación = row4[3].ToString();
                                Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(row4[4].ToString());
                                Bebida_Alcohólica.Stock = Convert.ToInt32(row4[5].ToString());
                                Bebida_Alcohólica.GraduaciónAlcoholica = Convert.ToDecimal(row4[6].ToString());
                                Pedido.Bebidas.Add(Bebida_Alcohólica);
                            }
                        }
                    }
                    Pedido.CalcularMonto();
                    ListadePedidos.Add(Pedido);
                }
            }
            else
            {
                ListadePedidos = null;
            }
            return ListadePedidos;
        }

        public BE_Pedido ListarObjeto(BE_Pedido Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
