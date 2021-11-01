using Datos.Data;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmEspecialidad
    {
        static DbClinicaContext context = new DbClinicaContext();

        public static List<Especialidad> Listar()
        {
            DbClinicaContext context = new DbClinicaContext();
            return context.Especialidades.ToList<Especialidad>();//retornamos todas las Especialidades
        }
    }
}
