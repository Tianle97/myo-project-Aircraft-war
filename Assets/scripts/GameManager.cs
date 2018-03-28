using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Gamestate {
     Running,
     Pause

}

public class GameManager : MonoBehaviour {
    public static GameManager _instance;
    public int Score = 0;
    public  GUIText D;
    
    
    
    
      
    
    
    
    
    public Gamestate gamestate = Gamestate.Running;
     void Awake()
    {
        _instance = this;

        //if(D==null)


        GameObject.FindGameObjectWithTag("ScoreGui");

    }

        // Update is called once per frame
        void Update () {
          D.text = "Score:" + Score;
        }
    public void transfromGameState() {
        if (gamestate == Gamestate.Running) {
            PauseGame();
        }else
        if (gamestate == Gamestate.Pause) {
            continueGame();
        }
    }
    public void PauseGame() {
        Time.timeScale = 0;// time.delatTime=0
        gamestate = Gamestate.Pause;
    }
    public void continueGame() {
        Time.timeScale = 1;
        gamestate = Gamestate.Running;
    }
    }
