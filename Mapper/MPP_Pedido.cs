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
    public class MPP_Pedido : IGestionable<BE_Pedido>, IValidable<BE_Pedido>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Pedido oBE_Pedido)
        {
            Hashtable hashtable = new Hashtable();
            string query = "23 - Cancelar_Pedido";
            hashtable.Add("@Codigo", oBE_Pedido.Codigo);
            hashtable.Add("@Codigo_Mesa", oBE_Pedido.CodigoMesa.Codigo);
            Acceso = new ClsDataBase();
            return Acceso.Escribir(query, hashtable);
        }

        public bool Existe(BE_Pedido Objeto)
        {
            throw new NotImplementedException();
        }

        public bool ExisteActivo(BE_Pedido Objeto)
        {
            throw new NotImplementedException();
        }
        public bool Guardar(BE_Pedido oBE_Pedido)
        {
            Hashtable hashtable = new Hashtable();
            string query = "22 - Cerrar_Pedido";
            hashtable.Add("@Codigo", oBE_Pedido.Codigo);
            hashtable.Add("@Codigo_Mesa", oBE_Pedido.CodigoMesa.Codigo);
            Acceso = new ClsDataBase();
            return Acceso.Escribir(query, hashtable);
        }

        public bool ActualizarMonto(BE_Pedido pedido)
        {
            Hashtable hashtable = new Hashtable();
            string query = "56 - Actualizar_Monto";
            hashtable.Add("@Codigo", pedido.Codigo);
            hashtable.Add("@Monto", pedido.Monto);
            Acceso = new ClsDataBase();
            return Acceso.Escribir(query, hashtable);
        }

        public List<BE_Pedido> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Pedido> ListadePedidos = new List<BE_Pedido>();
            DataTable Dt = Acceso.DevolverListado("21 - Listar_Pedido", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Pedido Pedido = new BE_Pedido();
                    Pedido.Codigo = Convert.ToInt32(row[0].ToString());
                    Pedido.FechaHoradeInicio = Convert.ToDateTime(row[1].ToString());
                    if (!(row[2] is DBNull))
                    {
                        Pedido.Observaciones = row[2].ToString();
                    }
                    else
                    {
                        Pedido.Observaciones = null;
                    }
                    if (!(row[7] is DBNull)) { Pedido.Monto = Convert.ToDecimal(row[7].ToString()); }
                    else { Pedido.Monto = 0; }
                    Pedido.Activo = Convert.ToBoolean(row[5].ToString());
                    
                    if (!(row[3] is DBNull))
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@Codigo", Convert.ToInt32(row[3].ToString()));
                        DataTable Dt1 = Acceso.DevolverListado("24 - Listar_Mesa_Pedido", hashtable);
                        if (Dt1.Rows.Count > 0)
                        {
                            foreach (DataRow row1 in Dt1.Rows)
                            {
                                BE_Mesa Mesa = new BE_Mesa();
                                Mesa.Codigo = Convert.ToInt32(row1[0].ToString());
                                Mesa.ID_Mesa = row1[1].ToString();
                                Mesa.Capacidad = Convert.ToInt32(row1[2].ToString());
                                if (!(row1[3] is DBNull)) { Mesa.CantidadComensales = Convert.ToInt32(row1[3].ToString()); }
                                else { Mesa.CantidadComensales = 0; }
                                Mesa.Status = (BE_Mesa.Estado)Enum.Parse(typeof(BE_Mesa.Estado), row1[4].ToString());
                                Pedido.CodigoMesa = Mesa;
                            }
                        }

                    }
                    if (!(row[4] is DBNull))
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@Codigo", Convert.ToInt32(row[4].ToString()));
                        DataTable Dt2 = Acceso.DevolverListado("25 - Listar_Mozo_Pedido", hashtable); 
                        if (Dt2.Rows.Count > 0)
                        {
                            foreach(DataRow row2 in Dt2.Rows)
                            {
                                BE_Mozo Mozo = new BE_Mozo();
                                Mozo.Codigo = Convert.ToInt32(row2[0].ToString());
                                Mozo.DNI = Convert.ToInt32(row2[1].ToString());
                                Mozo.Nombre = row2[2].ToString();
                                Mozo.Apellido = row2[3].ToString();
                                Mozo.FechaNacimiento = Convert.ToDateTime(row2[4].ToString());
                                Mozo.Edad = Mozo.CalcularAños(Mozo.FechaNacimiento);
                                Mozo.FechaIngreso = Convert.ToDateTime(row2[5].ToString());
                                Mozo.Antiguedad = Mozo.CalcularAños(Mozo.FechaIngreso);
                                BE_Turno oBE_Turno = new BE_Turno();
                                oBE_Turno.Codigo = Convert.ToInt32(row2[9].ToString());
                                oBE_Turno.NombreTurno = row2[10].ToString();
                                oBE_Turno.HoraInicio = Convert.ToDateTime(row2[11].ToString());
                                oBE_Turno.HoraFin = Convert.ToDateTime(row2[12].ToString());
                                Mozo.Turno = oBE_Turno;
                                Pedido.CodigoMozo = Mozo;
                            }
                        }
                    }
                    Hashtable hash = new Hashtable();
                    hash.Add("@Codigo", Pedido.Codigo);
                    DataTable Dt3 = Acceso.DevolverListado("26 - Listar_Plato_Pedido", hash); 
                    if (Dt3.Rows.Count > 0)
                    {
                        foreach (DataRow row3 in Dt3.Rows)
                        {
                            BE_Plato Plato = new BE_Plato();
                            Plato.Codigo = Convert.ToInt32(row3[0].ToString());
                            Plato.Nombre = row3[1].ToString();
                            Plato.Tipo_Plato = (BE_Plato.Tipo)Enum.Parse(typeof(BE_Plato.Tipo), row3[2].ToString());
                            Plato.Clasificacion = (BE_Plato.Clasificación)Enum.Parse(typeof(BE_Plato.Clasificación), row3[3].ToString());
                            if (!(row3[4] is DBNull))
                            { Plato.Stock = Convert.ToInt32(row3[4].ToString()); }
                            else { Plato.Stock = 0; }
                            Plato.CostoUnitario = Convert.ToDecimal(row3[5].ToString());
                            Pedido.Platos.Add(Plato);
                        }
                    }
                    DataTable Dt4 = Acceso.DevolverListado("27 - Listar_Bebida_Pedido", hash);
                    if (Dt4.Rows.Count > 0)
                    {
                        foreach(DataRow row4 in Dt4.Rows)
                        {
                            BE_Bebida Bebida = new BE_Bebida();
                            BE_Bebida_Alcohólica Bebida_Alcohólica = new BE_Bebida_Alcohólica();
                            if (row4[6] is DBNull)
                            {
                                Bebida.Codigo = Convert.ToInt32(row4[0].ToString());
                                Bebida.Nombre = row4[1].ToString();
                                Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row4[2].ToString());
                                Bebida.Presentación = Convert.ToDecimal(row4[3].ToString());
                                if (!(row4[4] is DBNull))
                                { Bebida.Stock = Convert.ToInt32(row4[4].ToString()); }
                                else { Bebida.Stock = 0; }
                                Bebida.CostoUnitario = Convert.ToDecimal(row4[5].ToString());
                                Pedido.Bebidas.Add(Bebida);
                            }
                            else
                            {
                                Bebida_Alcohólica.Codigo = Convert.ToInt32(row4[0].ToString());
                                Bebida_Alcohólica.Nombre = row4[1].ToString();
                                Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row4[2].ToString());
                                Bebida_Alcohólica.Presentación = Convert.ToDecimal(row4[3].ToString());
                                if (!(row4[4] is DBNull))
                                { Bebida_Alcohólica.Stock = Convert.ToInt32(row4[4].ToString()); }
                                else { Bebida_Alcohólica.Stock = 0; }
                                Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(row4[5].ToString());
                                Bebida_Alcohólica.GraduaciónAlcoholica = Convert.ToDecimal(row4[6].ToString());
                                Pedido.Bebidas.Add(Bebida_Alcohólica);
                            }
                        }
                    }
                    ListadePedidos.Add(Pedido);
                }
            }
            else
            {
                ListadePedidos = null;
            }
            return ListadePedidos;
        }

        public List<BE_Pedido> PlatoEnPedidos(BE_Plato oBE_Plato)
        {
            Acceso = new ClsDataBase();
            List<BE_Pedido> ListadePedidos = new List<BE_Pedido>();
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_Plato", oBE_Plato.Codigo);
            DataTable Dt = Acceso.DevolverListado("26 - Listar_Plato_Pedido", hash);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Pedido Pedido = new BE_Pedido();
                    Pedido.Codigo = Convert.ToInt32(row[7].ToString());
                    Pedido.FechaHoradeInicio = Convert.ToDateTime(row[8].ToString());
                    if (!(row[9] is DBNull))
                    {
                        Pedido.Observaciones = row[9].ToString();
                    }
                    else
                    {
                        Pedido.Observaciones = null;
                    }
                    Pedido.Monto = Convert.ToDecimal(row[14].ToString());
                    Pedido.Activo = Convert.ToBoolean(row[12].ToString());
                    ListadePedidos.Add(Pedido);
                }
            }
            else
            {
                ListadePedidos = null;
            }
            return ListadePedidos;
        }
        public List<BE_Pedido> BebidaEnPedidos(BE_Bebida oBE_Bebida)
        {
            Acceso = new ClsDataBase();
            List<BE_Pedido> ListadePedidos = new List<BE_Pedido>();
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_Bebida", oBE_Bebida.Codigo);
            DataTable Dt = Acceso.DevolverListado("27 - Listar_Bebida_Pedido", hash);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Pedido Pedido = new BE_Pedido();
                    Pedido.Codigo = Convert.ToInt32(row[8].ToString());
                    Pedido.FechaHoradeInicio = Convert.ToDateTime(row[9].ToString());
                    if (!(row[10] is DBNull))
                    {
                        Pedido.Observaciones = row[10].ToString();
                    }
                    else
                    {
                        Pedido.Observaciones = null;
                    }
                    Pedido.Monto = Convert.ToDecimal(row[15].ToString());
                    Pedido.Activo = Convert.ToBoolean(row[13].ToString());
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
