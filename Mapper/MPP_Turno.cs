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
    public class MPP_Turno : IGestionable<BE_Turno>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Turno oBE_Turno)
        {
            if (ExisteMozoenTurno(oBE_Turno) == false)
            {
                string query = @"Delete from Turno where [Codigo_Turno]=" + oBE_Turno.Codigo;
                Acceso = new ClsDataBase();
                return Acceso.EscribirTransaction(query);
            }
            else
            {
                return false;
            }
        }

        public bool Guardar(BE_Turno Turno)
        {
            string query;

            if (Turno.Codigo != 0)
            {
                query = @"Update Turno set [Nombre Turno]= '" + Turno.NombreTurno + "', [Hora Inicio]= '" + Turno.HoraInicio.ToString("HH:mm") + "', [Hora Fin]= '" + Turno.HoraFin.ToString("HH:mm") + "' where Codigo_Turno= " + Turno.Codigo;
            }
            else
            {
                query = @"Insert into Turno ([Nombre Turno], [Hora Inicio], [Hora Fin]) values ( '" + Turno.NombreTurno + "','" + Turno.HoraInicio.ToString("HH:mm") + "','" + Turno.HoraFin.ToString("HH:mm") + "')";
            }
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public List<BE_Turno> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Turno";
            Ds = Acceso.DevolverListado(query);
            List<BE_Turno> ListadeTurnos = new List<BE_Turno>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Turno Turno = new BE_Turno();
                    Turno.Codigo = Convert.ToInt32(row[0].ToString());
                    Turno.NombreTurno = row[1].ToString();
                    Turno.HoraInicio = Convert.ToDateTime(row[2].ToString());
                    Turno.HoraFin = Convert.ToDateTime(row[3].ToString());
                    ListadeTurnos.Add(Turno);
                }
            }
            else
            {
                ListadeTurnos = null;
            }
            return ListadeTurnos;
        }

        public BE_Turno ListarObjeto(BE_Turno Obe_Turno)
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Turno, Mozo where Turno.Codigo_Turno=Mozo.Codigo_Turno and Turno.Codigo_Turno= " + Obe_Turno.Codigo;
            Ds = Acceso.DevolverListado(query);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Obe_Turno.Mozos.Clear();
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Mozo Mozo = new BE_Mozo();
                    Mozo.Codigo = Convert.ToInt32(row[4].ToString());
                    Mozo.DNI = long.Parse(row[5].ToString());
                    Mozo.Nombre = row[6].ToString();
                    Mozo.Apellido = row[7].ToString();
                    Mozo.FechaNacimiento = Convert.ToDateTime(row[8].ToString());
                    Mozo.Edad = Mozo.DevolverEdad();
                    Mozo.Turno = Obe_Turno;
                    Obe_Turno.Mozos.Add(Mozo);
                }
            }
            return Obe_Turno;
        }
        public int CantidadMozosEnTurno(BE_Turno oBE_Turno)
        {
            Acceso = new ClsDataBase();
            string query = @"select count(Turno.Codigo_Turno) from Turno, Mozo where Turno.Codigo_Turno=Mozo.Codigo_Turno and Turno.Codigo_Turno= " + oBE_Turno.Codigo;
            return Acceso.Cantidades(query);
        }
        public bool ExisteMozoenTurno(BE_Turno oBE_Turno)
        {
            Acceso = new ClsDataBase();
            string query = @"Select count (Legajo) from Mozo where Codigo_Turno= " + oBE_Turno.Codigo;
            return Acceso.LeerScalar(query);
        }
    }
}
