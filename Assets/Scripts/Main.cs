using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NikolayTrofimovUnityC
{
    public class Main : MonoBehaviour
    {
        private PlayerBall _player;
        
        private void Start()
        {
            _player = FindObjectOfType<PlayerBall>();
        }

        private void FixedUpdate()
        {
            if (_player != null)
            {
                _player.Move();
            }
        }
    }
}
