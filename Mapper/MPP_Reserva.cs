using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;
using System.Data;
using System.Collections;

namespace Mapper
{
    public class MPP_Reserva : IGestionable<BE_Reserva>, IValidable<BE_Reserva>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Reserva oBE_Reserva)
        {
            if (!ExisteActivo(oBE_Reserva))
            {
                Hashtable hashtable = new Hashtable();
                string query = "35 - Cancelar_Reserva";
                hashtable.Add("@Codigo", oBE_Reserva.Codigo);
                hashtable.Add("@Codigo_Mesa", oBE_Reserva.MesaReservada.Codigo);
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public bool Modificar(BE_Reserva Reserva, BE_Mesa Mesa)
        {
            Hashtable hashtable = new Hashtable();
            string query = "34 - Modificar_Mesa";
            hashtable.Add("@Codigo", Reserva.Codigo);
            hashtable.Add("@Codigo_Mesa", Mesa.Codigo);
            hashtable.Add("@Codigo_Mesa_Viejo", Reserva.MesaReservada.Codigo);
            hashtable.Add("@Ocupacion", Reserva.MesaReservada.CantidadComensales);
            Acceso = new ClsDataBase();
            return Acceso.Escribir(query, hashtable);
        }
        public bool Guardar(BE_Reserva Reserva, BE_Mesa Mesa)
        {
            Hashtable hashtable = new Hashtable();
            string query = "33 - Asignar_Mesa";
            hashtable.Add("@Codigo", Reserva.Codigo);
            hashtable.Add("@Codigo_Mesa", Mesa.Codigo);
            hashtable.Add("Ocupacion", Reserva.CantidadDeComensales);

            if (!Existe(Reserva))
            {
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else { return false; }
        }

        public List<BE_Reserva> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Reserva> ListadeReservas = new List<BE_Reserva>();
            DataTable Dt = Acceso.DevolverListado("32 - Listar_Reserva", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Reserva Reserva = new BE_Reserva();
                    Reserva.Codigo = Convert.ToInt32(row[0].ToString());
                    Reserva.FechaReserva = Convert.ToDateTime(row[3].ToString());
                    Reserva.HoraReserva = Convert.ToDateTime(row[4].ToString());
                    Reserva.CantidadDeComensales = Convert.ToInt32(row[5].ToString());
                    Reserva.Recibida = Convert.ToBoolean(row[6].ToString());
                    Reserva.Estado = Convert.ToBoolean(row[7].ToString());
                    if (!(row[1] is DBNull))
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@Codigo", Convert.ToInt32(row[1].ToString()));
                        DataTable Dt1 = Acceso.DevolverListado("24 - Listar_Mesa_Pedido", hashtable);
                        if (Dt1.Rows.Count > 0)
                        {
                            foreach (DataRow row1 in Dt1.Rows)
                            {
                                BE_Mesa Mesa = new BE_Mesa();
                                Mesa.Codigo = Convert.ToInt32(row1[0].ToString());
                                Mesa.ID_Mesa = row1[1].ToString();
                                Mesa.Capacidad = Convert.ToInt32(row1[2].ToString());
                                if (!(row1[3]is DBNull)) { Mesa.CantidadComensales = Convert.ToInt32(row1[3].ToString()); }
                                else { Mesa.CantidadComensales = 0; }
                                Mesa.Status = (BE_Mesa.Estado)Enum.Parse(typeof(BE_Mesa.Estado), row1[4].ToString());
                                Reserva.MesaReservada = Mesa;
                            }
                        }
                    }
                    if (!(row[2] is DBNull))
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@Codigo", Convert.ToInt32(row[2].ToString()));
                        DataTable Dt2 = Acceso.DevolverListado("59 - Listar_Reserva_Pedido", hashtable);
                        if (Dt2.Rows.Count > 0)
                        {
                            foreach(DataRow row2 in Dt2.Rows)
                            {
                                BE_Pedido Pedido = new BE_Pedido();
                                Pedido.Codigo = Convert.ToInt32(row2[0].ToString());
                                Pedido.FechaHoradeInicio = Convert.ToDateTime(row2[1].ToString());
                                if (!(row2[2] is DBNull))
                                {
                                    Pedido.Observaciones = row2[2].ToString();
                                }
                                else
                                {
                                    Pedido.Observaciones = null;
                                }
                                if (!(row2[7] is DBNull)) { Pedido.Monto = Convert.ToDecimal(row2[7].ToString()); }
                                else { Pedido.Monto = 0; }
                                Pedido.Activo = Convert.ToBoolean(row2[5].ToString());

                                if (!(row2[3] is DBNull))
                                {
                                    Hashtable hash1 = new Hashtable();
                                    hash1.Add("@Codigo", Convert.ToInt32(row2[3].ToString()));
                                    DataTable Dt3 = Acceso.DevolverListado("24 - Listar_Mesa_Pedido", hash1);
                                    if (Dt3.Rows.Count > 0)
                                    {
                                        foreach (DataRow row3 in Dt3.Rows)
                                        {
                                            BE_Mesa Mesa = new BE_Mesa();
                                            Mesa.Codigo = Convert.ToInt32(row3[0].ToString());
                                            Mesa.ID_Mesa = row3[1].ToString();
                                            Mesa.Capacidad = Convert.ToInt32(row3[2].ToString());
                                            if (!(row3[3] is DBNull)) { Mesa.CantidadComensales = Convert.ToInt32(row3[3].ToString()); }
                                            else { Mesa.CantidadComensales = 0; }
                                            Mesa.Status = (BE_Mesa.Estado)Enum.Parse(typeof(BE_Mesa.Estado), row3[4].ToString());
                                            Pedido.CodigoMesa = Mesa;
                                        }
                                    }

                                }
                                if (!(row[4] is DBNull))
                                {
                                    Hashtable hash2 = new Hashtable();
                                    hash2.Add("@Codigo", Convert.ToInt32(row2[4].ToString()));
                                    DataTable Dt4 = Acceso.DevolverListado("25 - Listar_Mozo_Pedido", hash2);
                                    if (Dt4.Rows.Count > 0)
                                    {
                                        foreach (DataRow row4 in Dt4.Rows)
                                        {
                                            BE_Mozo Mozo = new BE_Mozo();
                                            Mozo.Codigo = Convert.ToInt32(row4[0].ToString());
                                            Mozo.DNI = Convert.ToInt32(row4[1].ToString());
                                            Mozo.Nombre = row4[2].ToString();
                                            Mozo.Apellido = row4[3].ToString();
                                            Mozo.FechaNacimiento = Convert.ToDateTime(row4[4].ToString());
                                            Mozo.Edad = Mozo.CalcularAños(Mozo.FechaNacimiento);
                                            Mozo.FechaIngreso = Convert.ToDateTime(row4[5].ToString());
                                            Mozo.Antiguedad = Mozo.CalcularAños(Mozo.FechaIngreso);
                                            BE_Turno oBE_Turno = new BE_Turno();
                                            oBE_Turno.Codigo = Convert.ToInt32(row4[9].ToString());
                                            oBE_Turno.NombreTurno = row4[10].ToString();
                                            oBE_Turno.HoraInicio = Convert.ToDateTime(row4[11].ToString());
                                            oBE_Turno.HoraFin = Convert.ToDateTime(row4[12].ToString());
                                            Mozo.Turno = oBE_Turno;
                                            Pedido.CodigoMozo = Mozo;
                                        }
                                    }
                                }
                                Hashtable hash3 = new Hashtable();
                                hash3.Add("@Codigo", Pedido.Codigo);
                                DataTable Dt5 = Acceso.DevolverListado("26 - Listar_Plato_Pedido", hash3);
                                if (Dt5.Rows.Count > 0)
                                {
                                    foreach (DataRow row5 in Dt5.Rows)
                                    {
                                        BE_Plato Plato = new BE_Plato();
                                        Plato.Codigo = Convert.ToInt32(row5[0].ToString());
                                        Plato.Nombre = row5[1].ToString();
                                        Plato.Tipo_Plato = (BE_Plato.Tipo)Enum.Parse(typeof(BE_Plato.Tipo), row5[2].ToString());
                                        Plato.Clasificacion = (BE_Plato.Clasificación)Enum.Parse(typeof(BE_Plato.Clasificación), row5[3].ToString());
                                        if (!(row5[4] is DBNull))
                                        { Plato.Stock = Convert.ToInt32(row5[4].ToString()); }
                                        else { Plato.Stock = 0; }
                                        Plato.CostoUnitario = Convert.ToDecimal(row5[5].ToString());
                                        Pedido.Platos.Add(Plato);
                                    }
                                }
                                DataTable Dt6 = Acceso.DevolverListado("27 - Listar_Bebida_Pedido", hash3);
                                if (Dt6.Rows.Count > 0)
                                {
                                    foreach (DataRow row6 in Dt6.Rows)
                                    {
                                        BE_Bebida Bebida = new BE_Bebida();
                                        BE_Bebida_Alcohólica Bebida_Alcohólica = new BE_Bebida_Alcohólica();
                                        if (row6[6] is DBNull)
                                        {
                                            Bebida.Codigo = Convert.ToInt32(row6[0].ToString());
                                            Bebida.Nombre = row6[1].ToString();
                                            Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row6[2].ToString());
                                            Bebida.Presentación = Convert.ToDecimal(row6[3].ToString());
                                            if (!(row6[4] is DBNull))
                                            { Bebida.Stock = Convert.ToInt32(row6[4].ToString()); }
                                            else { Bebida.Stock = 0; }
                                            Bebida.CostoUnitario = Convert.ToDecimal(row6[5].ToString());
                                            Pedido.Bebidas.Add(Bebida);
                                        }
                                        else
                                        {
                                            Bebida_Alcohólica.Codigo = Convert.ToInt32(row6[0].ToString());
                                            Bebida_Alcohólica.Nombre = row6[1].ToString();
                                            Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row6[2].ToString());
                                            Bebida_Alcohólica.Presentación = Convert.ToDecimal(row6[3].ToString());
                                            if (!(row6[4] is DBNull))
                                            { Bebida_Alcohólica.Stock = Convert.ToInt32(row6[4].ToString()); }
                                            else { Bebida_Alcohólica.Stock = 0; }
                                            Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(row6[5].ToString());
                                            Bebida_Alcohólica.GraduaciónAlcoholica = Convert.ToDecimal(row6[6].ToString());
                                            Pedido.Bebidas.Add(Bebida_Alcohólica);
                                        }
                                    }
                                }
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

        public bool Existe(BE_Reserva Reserva)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo", Reserva.Codigo);
            return Acceso.Scalar("58 - Existe_Mesa_Reserva", hash);
        }

        public bool ExisteActivo(BE_Reserva Reserva)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo", Reserva.Codigo);
            return Acceso.Scalar("57 - Existe_Reserva_Activa", hash);
        }
    }
}
