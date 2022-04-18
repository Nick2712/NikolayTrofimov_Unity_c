using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NikolayTrofimovUnityC
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - _player.gameObject.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = _player.gameObject.transform.position + _offset;
        }
    }
}
