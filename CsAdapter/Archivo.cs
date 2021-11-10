using System;

namespace CsAdapter
{
    internal class Archivo
    {
        private string v;

        public Archivo(string v)
        {
            this.v = v;
        }

        internal void OpenForWrite()
        {
            Console.Write("Archivo abierto para escritura");
        }

        internal void Escribir(string dato)
        {
            Console.Write("Escribiendo dato: " + dato);
        }

        internal bool Guardar()
        {
            return true;
        }
    }
}