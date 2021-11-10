using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAdapter
{
    public class Cliente
    {
        private ServicioInterface servicio;
        public void SetServicio(ServicioInterface servicio)
        {
            this.servicio = servicio;
        }

        public bool EnviarInfoAlServicio(string informacion)
        {
            return servicio.Escribir(informacion);
            
        }
    }
}
