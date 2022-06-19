using UnityEngine;


namespace NikolayTrofimovUnityC
{
    internal abstract class InteractiveObject : MonoBehaviour
    {
        private const string PLAYER_TAG = "Player";

        protected abstract void Interaction(PlayerBall playerBall);

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag(PLAYER_TAG))
            {
                Interaction(other.GetComponent<PlayerBall>());
                Destroy(gameObject);
            }
        }
    }
}
