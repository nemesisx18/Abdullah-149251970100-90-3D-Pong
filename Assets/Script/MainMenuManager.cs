using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject TutorialMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        Debug.Log("Loading Game");
        SceneManager.LoadScene("Gameplay");
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

    public void OpenTutorial()
    {
        Debug.Log("Tutorial Open");
    }
}
