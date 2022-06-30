using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayUIManager : MonoBehaviour
{
    public GameObject[] playerText;
    
    public void GameOver(int go)
    {
        playerText[go].SetActive(true);
        Time.timeScale = 0;
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
