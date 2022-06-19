using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal sealed class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        [SerializeField] private float _maxFlyHeigth = 1.0f;
        [SerializeField] private float _speedBonus = 20.0f;
        [SerializeField] private float _timeSpeedBonus = 5.0f;
        [SerializeField] private float _timeInvulBonus = 5.0f;
        private Material _material;
        private float _lowerPosition;
        private DisplayBonuses _displayBonuses;
        private Effects[] _effects;


        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lowerPosition = transform.position.y;
            _displayBonuses = new DisplayBonuses();
            _effects = new Effects[] { Effects.SpeedChange, Effects.Invul };
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

        protected override void Interaction(PlayerBall playerBall)
        {
            _displayBonuses.Display(5);
            var effect = _effects[Random.Range(0, _effects.Length)];
            if (effect == Effects.SpeedChange) playerBall.ChangeSpeed(_timeSpeedBonus, _speedBonus);
            if (effect == Effects.Invul) playerBall.Invul(_timeInvulBonus);
        }
    }
}
