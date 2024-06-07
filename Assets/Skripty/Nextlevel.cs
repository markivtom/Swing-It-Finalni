using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportTrigger : MonoBehaviour
{
    // Name of the scene to load
    public string targetScene;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger zone
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered the trigger zone.");
            // Check if the target scene name is set
            if (!string.IsNullOrEmpty(targetScene))
            {
                Debug.Log("Loading scene: " + targetScene);
                SceneManager.LoadScene(targetScene);
                AudioManager.Instance.PlaySFX("TP");
            }
            else
            {
                Debug.LogWarning("Target scene name is not set.");
            }
        }
        else
        {
            Debug.Log("Another object entered the trigger zone: " + other.name);
        }
    }
}