using System;

namespace _18_Propiedades
{
    class Printer2 : IPrinter
    {
        public virtual int X
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class PrinterDerivada:Printer2
    {
        public override int X
        {
            get
            {
                return base.X;
            }
            set
            {
                base.X = value;
            }
        }
    }
}