namespace _16_InterfasesAbstractas
{
   
    sealed class Circulo: FiguraBase,IFigura,IRenderizador   
    {
        int radio;

        public int Calcular(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public double CalcularArea()
        {
            throw new System.NotImplementedException();
        }

        void IFigura.Dibujar()
        {
            throw new System.NotImplementedException();
        }

        void IRenderizador.Dibujar()
        {
            throw new System.NotImplementedException();
        }

        public void Renderizar()
        {
            throw new System.NotImplementedException();
        }

        public override void ObtenerTop()
        {
            throw new System.NotImplementedException();
        }
    }
}