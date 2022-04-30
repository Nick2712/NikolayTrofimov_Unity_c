using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal abstract class InteractiveObject : MonoBehaviour
    {
        protected abstract void Interaction(PlayerBall playerBall);

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                Interaction(other.GetComponent<PlayerBall>());
                Destroy(gameObject);
            }
        }
    }
}
