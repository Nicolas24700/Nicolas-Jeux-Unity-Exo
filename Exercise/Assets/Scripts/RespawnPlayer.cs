using UnityEngine;
using Unity.Cinemachine;

namespace StarterAssets
{
    [RequireComponent(typeof(CharacterController))]
    public class RespawnPlayer : MonoBehaviour
    {
        // Feature added : Player respawn script, taken from the script present in the player robot in the tutorial of unity which I modified. 
        public float yThreshold = -5f;
        private CharacterController _characterController;
        public AudioClip respawnSound;


        private void Start()
        {
            // Get the CharacterController reference
            _characterController = GetComponent<CharacterController>();
            if (_characterController == null)
            {
                Debug.LogError("CharacterController component is required for RespawnPlayer script!");
            }
        }

        private void Update()
        {
            // Check if the player's Y position has fallen below the threshold
            if (transform.position.y < yThreshold)
            {
                Respawn();
            }
        }

        public void Respawn()
        {
            // Disable the CharacterController so we can manually adjust position
            if (_characterController != null)
            {
                _characterController.enabled = false;
                transform.position = new Vector3(0, 0, 0);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                _characterController.enabled = true;
                AudioSource.PlayClipAtPoint(respawnSound, transform.position);
            }
        }
    }
}
