using System;

namespace _15_Herencia
{
    class MultimediaFile
    {
        public string fechaCreacion;
        string fechaModificacion;
        string nombre;
        string tipoElemento;

        public void DesplegarInformacion()
        {
            string informacion = fechaCreacion + " " + fechaModificacion + " " + nombre + " " + tipoElemento;
            Console.WriteLine(informacion);
        }
    }
}