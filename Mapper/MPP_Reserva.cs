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
    public class MPP_Reserva : IGestionable<BE_Reserva>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Reserva oBE_Reserva)
        {
            if (oBE_Reserva.MesaReservada != null)
            {
                string[] query = new string[2];
                query[0] = @"Update Reserva set Estado= 0, Nro_Mesa = NULL where Codigo_Reserva= " + oBE_Reserva.Codigo;
                query[1] = @"update Mesa set Estado= 'Disponible', CantidadComensales=0 where Mesa.Id_Mesa=" + oBE_Reserva.MesaReservada.Codigo;
                Acceso = new ClsDataBase();
                return Acceso.EscribirTransaction(query);
            }
            else
            {
                string query = @"Update Reserva set Estado= 0, Nro_Mesa = NULL where Codigo_Reserva= " + oBE_Reserva.Codigo;
                Acceso = new ClsDataBase();
                return Acceso.EscribirTransaction(query);
            }

        }

        public bool Modificar(BE_Reserva Reserva, BE_Mesa Mesa)
        {
            string[] query = new string[3];
            query[0] = @"update Mesa set Estado= 'Disponible', CantidadComensales=0 where Mesa.Id_Mesa=" + Reserva.MesaReservada.Codigo;
            query[1] = @"update Reserva set Nro_Mesa=" + Mesa.Codigo + " where Codigo_Reserva=" + Reserva.Codigo;
            query[2] = @"update Mesa set Estado= 'Ocupada', CantidadComensales= " + Reserva.CantidadDeComensales + " where Mesa.Id_Mesa=" + Mesa.Codigo;
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }
        public bool Guardar(BE_Reserva Reserva, BE_Mesa Mesa)
        {
            string[] query = new string[2];
            query[0] = @"update Reserva set Nro_Mesa=" + Mesa.Codigo + " where Codigo_Reserva=" + Reserva.Codigo;
            query[1] = @"update Mesa set Estado= 'Ocupada', CantidadComensales= " + Reserva.CantidadDeComensales + " where Mesa.Id_Mesa=" + Mesa.Codigo;
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public List<BE_Reserva> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Reserva where Estado = 1";
            Ds = Acceso.DevolverListado(query);
            List<BE_Reserva> ListadeReservas = new List<BE_Reserva>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Reserva Reserva = new BE_Reserva();
                    Reserva.Codigo = Convert.ToInt32(row[0].ToString());
                    Reserva.FechaReserva = Convert.ToDateTime(row[3].ToString());
                    Reserva.CantidadDeComensales = Convert.ToInt32(row[4].ToString());
                    Reserva.Estado = Convert.ToBoolean(row[5].ToString());
                    if (!(row[1] is DBNull))
                    {
                        DataSet Ds1;
                        string query1 = @"select * from Mesa where Mesa.Id_Mesa= " + Convert.ToInt32(row[1].ToString());
                        Ds1 = Acceso.DevolverListado(query1);
                        if (Ds1.Tables[0].Rows.Count > 0)
                        {
                            foreach(DataRow row1 in Ds1.Tables[0].Rows)
                            {
                                BE_Mesa Mesa = new BE_Mesa();
                                Mesa.Codigo = Convert.ToInt32(row1[0].ToString());
                                Mesa.NroDeMesa = Convert.ToInt32(row1[1].ToString());
                                Mesa.Capacidad = Convert.ToInt32(row1[2].ToString());
                                Mesa.Estado = row1[3].ToString();
                                Mesa.CantidadComensales = Convert.ToInt32(row1[4].ToString());
                                Reserva.MesaReservada = Mesa;
                            }
                        }
                    }
                    if (!(row[2] is DBNull))
                    {
                        DataSet Ds2;
                        string query2 = @"select * from Pedido where Pedido.Codigo_Pedido = " + Convert.ToInt32(row[2].ToString());
                        Ds2 = Acceso.DevolverListado(query2);
                        if (Ds2.Tables[0].Rows.Count > 0)
                        {
                            foreach(DataRow row2 in Ds2.Tables[0].Rows)
                            {
                                BE_Pedido Pedido = new BE_Pedido();
                                Pedido.Codigo = Convert.ToInt32(row2[0].ToString());
                                Pedido.FechaHoradeInicio = Convert.ToDateTime(row2[3].ToString());
                                Pedido.Observaciones = row2[4].ToString();
                                Pedido.Monto = Convert.ToDecimal(row2[5].ToString());
                                Pedido.Activo = Convert.ToBoolean(row2[6].ToString());
                                Pedido.Cancelado = Convert.ToBoolean(row2[7].ToString());
                                Reserva.PedidoReservado = Pedido;
                            }
                        }
                    }
                    ListadeReservas.Add(Reserva);
                }
            }
            else
            {
                ListadeReservas = null;
            }
            return ListadeReservas;
        }

        public BE_Reserva ListarObjeto(BE_Reserva oBE_Reserva)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Reserva Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
