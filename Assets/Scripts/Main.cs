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

            //var objects = new ListIntractiveObject();
            //foreach(var obj in objects)
            //{
            //    Debug.Log(obj);
            //}

            //SomeComparable[] tests = new SomeComparable[10];
            //for(int i = 0; i < tests.Length; i++)
            //{
            //    tests[i].Value = UnityEngine.Random.Range(0, 100);
            //}
            //foreach(var test in tests)
            //{
            //    Debug.Log(test.Value);
            //}
            //Debug.Log("---");
            //Array.Sort(tests);
            //foreach (var test in tests)
            //{
            //    Debug.Log(test.Value);
            //}
            //Debug.Log("---");
            //var comparer = new SomeComparableComparer();
            //List<SomeComparable> tests2 = tests.ToList();
            //tests2.Sort(comparer);
            //foreach (var test2 in tests2)
            //{
            //    Debug.Log(test2.Value);
            //}
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
