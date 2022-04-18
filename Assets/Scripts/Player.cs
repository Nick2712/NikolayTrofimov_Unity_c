using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NikolayTrofimovUnityC
{
    internal class Player : MonoBehaviour
    {
        [SerializeField] private float _speed = 10;
        protected float _health = 10;
        protected Rigidbody _rigidbody;

        public void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move()
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _rigidbody.AddForce(movement * _speed);
        }
    }
}
