using MedidoresModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModels.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }

        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }
    }
}
