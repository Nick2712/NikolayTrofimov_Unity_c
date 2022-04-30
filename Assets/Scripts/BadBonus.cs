using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal class BadBonus : InteractiveObject, IFly, IRotation
    {
        [SerializeField] private float _maxFlyHeigth = 1.0f;
        [SerializeField] private float _speedRotation = 60.0f;
        [SerializeField] private float _speedPenalty = 5.0f;
        [SerializeField] private float _timeSpeedPenalty = 5.0f;
        private float _lowerPosition;
        private Effects[] _effects;

        private void Awake()
        {
            _lowerPosition = transform.position.y;
            _effects = new Effects[] { Effects.Die, Effects.SpeedChange };
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

        protected override void Interaction(PlayerBall playerBall)
        {
            var effect = _effects[Random.Range(0, _effects.Length)];
            if (effect == Effects.Die) playerBall.Die();
            if (effect == Effects.SpeedChange) playerBall.ChangeSpeed(_timeSpeedPenalty, _speedPenalty);
        }
    }
}
