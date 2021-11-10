using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAdapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente client = new Cliente();
            client.SetServicio(new ServicioWeb());
            Console.WriteLine( client.EnviarInfoAlServicio("Hola como te va"));
            client.SetServicio(new SerivicioArchivoAdapter());
            Console.WriteLine(client.EnviarInfoAlServicio("Esto se envia al servicio"));
            Console.ReadKey();
        }
    }
}
