using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NikolayTrofimovUnityC
{
    internal class SomeComparableComparer : IComparer<SomeComparable>
    {
        public int Compare(SomeComparable x, SomeComparable y)
        {
            if(x.Value < y.Value) return 1;
            if(x.Value > y.Value) return -1;
            return 0;
        }
    }
}
