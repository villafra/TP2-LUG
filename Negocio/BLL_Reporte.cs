using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_Reporte
    {
        MPP_Reporte oMPP_Reporte;

        public BLL_Reporte()
        {
            oMPP_Reporte = new MPP_Reporte();
        } 
        public List<BE_Pedido> ListarReportes(BE_Reporte Reporte)
        {
            return oMPP_Reporte.ListarReportes(Reporte);
        }
    }
}
