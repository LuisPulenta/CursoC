namespace _15_Herencia
{
    static class MetodosExtension
    {
        public static int ContarPalabras(this string cadena)
        {
            var palabras = cadena.Split(' ');
            return palabras.Length;
        }
    }
}