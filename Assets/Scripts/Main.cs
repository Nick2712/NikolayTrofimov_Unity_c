using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace NikolayTrofimovUnityC
{
    public class Main : MonoBehaviour
    {
        private PlayerBall _player;
        private InteractiveObject[] _interactiveObjects;
        

        private void Start()
        {
            _player = FindObjectOfType<PlayerBall>();
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
            var cameraController = FindObjectOfType<CameraController>();
            foreach (var interactiveObject in _interactiveObjects)
            {
                interactiveObject.OnInteractionAction += cameraController.CameraShake.Shake;
            }
        }

        private void FixedUpdate()
        {
            if (_player != null) _player.Move();

            foreach(var interactiveObject in _interactiveObjects)
            {
                if (interactiveObject != null)
                {
                    if (interactiveObject is IFly fly) fly.Fly();
                    if (interactiveObject is IRotation rotation) rotation.Rotation();
                    if (interactiveObject is IFlicker flicker) flicker.Flicker();
                }
            }
        }
    }
}
