using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal sealed class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        [SerializeField] private float _maxFlyHeigth = 1.0f;
        private Material _material;
        private float _lowerPosition;
        private DisplayBonuses _displayBonuses;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lowerPosition = transform.position.y;
            _displayBonuses = new DisplayBonuses();
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, 
                _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, 
                _lowerPosition + Mathf.PingPong(Time.time, _maxFlyHeigth), transform.position.z);
        }

        protected override void Interaction()
        {
            _displayBonuses.Display(5);
        }
    }
}
