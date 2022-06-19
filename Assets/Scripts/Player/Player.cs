using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal class Player : MonoBehaviour
    {
        [SerializeField] protected float _speed = 10;
        protected float _health = 10;
        protected Rigidbody _rigidbody;
        

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public virtual void Move()
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _rigidbody.AddForce(movement * _speed);
        }
    }
}
