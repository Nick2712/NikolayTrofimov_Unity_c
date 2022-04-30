using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal abstract class InteractiveObject : MonoBehaviour
    {
        protected abstract void Interaction();

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                Interaction();
                Destroy(gameObject);
            }
        }
    }
}
