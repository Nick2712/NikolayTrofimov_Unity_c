using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NikolayTrofimovUnityC
{
    internal sealed class ListIntractiveObject : IEnumerator, IEnumerable
    {
        private InteractiveObject[] _interactiveObjects;
        private int _index = -1;

        public ListIntractiveObject()
        {
            _interactiveObjects = Object.FindObjectsOfType<InteractiveObject>();
        }

        public object Current => _interactiveObjects[_index];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_index + 1 == _interactiveObjects.Length)
            {
                Reset();
                return false;
            }
            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
