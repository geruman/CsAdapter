namespace CsAdapter
{
    public class SerivicioArchivoAdapter : ServicioInterface
    {
        private Archivo archivo;
        public SerivicioArchivoAdapter()
        {
            this.archivo = new Archivo("nombreDelArchivo");
        }
        public bool Escribir(string dato)
        {
            archivo.OpenForWrite();
            archivo.Escribir(dato);
            return archivo.Guardar();
        }
    }
}