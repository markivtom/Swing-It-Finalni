using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public  GameObject gameOverCanvas;
    public GameObject crosshair;
    GameOver1 GameOver;
    public Vector3 respawnLoc;
    public GameObject Player;

    private void Start()
    {
        GameOver = FindObjectOfType<GameOver1>();
        respawnLoc = Player.transform.position;
        
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit.");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
    }

    public void Retry()
    {
        Player.transform.position = respawnLoc;
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        crosshair.SetActive(true);
        GameOver.GameOver = false;

    }
}
