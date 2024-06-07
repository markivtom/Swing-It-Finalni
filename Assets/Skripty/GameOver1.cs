using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour
{
    public  GameObject gameOverCanvas;
    public GameObject crosshair;
    public bool GameOver;
    
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger zone
        if (other.CompareTag("Player"))
        {
            Death();
            
            Debug.Log("Player died");
        }
    }

    void Death()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        crosshair.SetActive(false);
        GameOver = true;
        
    }
}
