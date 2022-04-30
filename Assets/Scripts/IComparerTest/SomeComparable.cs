using System;


namespace NikolayTrofimovUnityC
{
    internal struct SomeComparable : IComparable<SomeComparable>
    {
        public int Value;
        public int CompareTo(SomeComparable obj)
        {
            if(Value > obj.Value) return 1;
            if(Value < obj.Value) return -1;
            return 0;
        }
    }
}
