using UnityEngine;

namespace NikolayTrofimovUnityC
{
    internal class CameraShake
    {
        private const float MAX_THRESHOLD = 0.2f;
        private const float SHAKE_SPEED = 10.0f;

        public float ShakeThreshold { get; private set; } = 0.0f;
        private bool _isShake = false;
        private float _shakeDuration = 1.0f;


        public void Shake()
        {
            _isShake = true;
        }

        public void Update(float deltaTime)
        {
            if( _isShake )
            {
                ShakeThreshold += deltaTime * SHAKE_SPEED * _shakeDuration;
                if( ShakeThreshold > MAX_THRESHOLD )
                {
                    ShakeThreshold = MAX_THRESHOLD;
                    _shakeDuration = -1.0f;
                }
                if( ShakeThreshold < 0.0f )
                {
                    ShakeThreshold = 0.0f;
                    _shakeDuration = 1.0f;
                    _isShake = false;
                }
            }
        }
    }
}