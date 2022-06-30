using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public BallSpawner ballSpawner;
    public GameplayUIManager gameplayUIManager;
    public List<PaddleController> playerControllerList;
    public GameObject winCanvas;

    public bool gameIsFinish;
    public int playerLose;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    private void Update()
    {
        if(gameIsFinish)
        {
            winCanvas.SetActive(true);
        }
    }

    public void CheckWin()
    {
        if (playerLose >= 3)
        {
            Time.timeScale = 0;
            gameIsFinish = true;
            int playerWinner;
            for (int i = 0; i < playerControllerList.Count; i++)
            {
                if (playerControllerList[i].isLost == false)
                {
                    playerWinner = playerControllerList[i].playerNumber;
                    gameplayUIManager.GameOver(playerWinner);
                }
            }
        }
    }
}
