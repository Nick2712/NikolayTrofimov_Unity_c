using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal sealed class CameraController : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private Vector3 _offset;
        private Vector3 _shakeOfset;
        public CameraShake CameraShake { get; private set; } = new CameraShake();


        private void Start()
        {
            _offset = transform.position - _player.gameObject.transform.position;
        }

        private void FixedUpdate()
        {
            CameraShake.Update(Time.fixedDeltaTime);
        }

        private void LateUpdate()
        {
            _shakeOfset.y = CameraShake.ShakeThreshold;
            transform.position = _player.gameObject.transform.position + _offset + _shakeOfset;
        }
    }
}
