using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal class BadBonus : InteractiveObject, IFly, IRotation
    {
        [SerializeField] private float _maxFlyHeigth = 1.0f;
        [SerializeField] private float _speedRotation = 60.0f;
        private float _lowerPosition;

        private void Awake()
        {
            _lowerPosition = transform.position.y;
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, 
                _lowerPosition + Mathf.PingPong(Time.time, _maxFlyHeigth), transform.position.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * Time.deltaTime * _speedRotation, Space.World);
        }

        protected override void Interaction()
        {
            
        }
    }
}
