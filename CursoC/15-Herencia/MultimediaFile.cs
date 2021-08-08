namespace _15_Herencia
{
    class MultimediaFile
    {
        protected string tipoArchivo;
        public virtual string ObtenerTipo()
        {
            string tArchivo = tipoArchivo;
            CalcularTamanio();
            return "Archivo Multimedia";
        }
        protected void CalcularTamanio()
        {
        }
    }
}