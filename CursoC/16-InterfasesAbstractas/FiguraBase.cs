using System;

namespace _16_InterfasesAbstractas
{
    class FIguraDerivadaAgain:FiguraDerivada
    {
        public override void ObtenerTop()
        {
            base.ObtenerTop();
        }
        public override void ObtenerUbicacion()
        {
            base.ObtenerUbicacion();
        }
    }
    
    
    class FiguraDerivada : FiguraBase
    {
        public sealed override void ObtenerUbicacion()
        {
            base.ObtenerUbicacion();
        }

        public sealed override void ObtenerTop()
        {
            throw new NotImplementedException();
        }
    }


    abstract class FiguraBase
    {
        protected string colorFigura;

        public virtual void ObtenerUbicacion()
        {
            Console.WriteLine("X,Y");
        }

        public abstract void ObtenerTop();
    }
}