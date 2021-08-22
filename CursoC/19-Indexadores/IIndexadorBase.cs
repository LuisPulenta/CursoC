namespace _19_Indexadores
{
    interface IIndexadorBase
    {
        bool this[int index]
        {
            get;
            set;
        }
    }

    class Bits2 : IIndexadorBase
    {
        public virtual bool this[int index] 
        {
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }
    }

    class Bits3:Bits2
    {
        public override bool this[int index] 
        { 
            get => base[index]; 
            set => base[index] = value; 
        }
    }
}