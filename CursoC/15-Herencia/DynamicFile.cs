namespace _15_Herencia
{
    class DynamicFile : MultimediaFile
    {
        public override string ObtenerTipo()
        {
            string tArchivo = tipoArchivo;
            CalcularTamanio();
            return "Archivo Dinámico";
        }
    }
}