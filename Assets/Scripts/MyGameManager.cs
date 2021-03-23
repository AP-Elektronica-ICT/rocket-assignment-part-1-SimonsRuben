using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;
    public GameObject mainCanvas;
    public GameObject deathCanvas;
    private Health healthplayer;
    public static int Score = 0;
    public enum GameStates
    {
        Playing,GameOver
    }
    public GameStates gameState = GameStates.Playing;
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        healthplayer = Player.GetComponent<Health>();
        deathCanvas.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempetxt = this.mainCanvas.transform.GetChild(0).gameObject;
        tempetxt.GetComponent<Text>().text = "Score: " + MyGameManager.Score;
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthplayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    mainCanvas.SetActive(false);
                    deathCanvas.SetActive(true);
                }
                break;
            case GameStates.GameOver:
                MyGameManager.Score = 0;
                break;
            default:
                break;
        }

    }

}
