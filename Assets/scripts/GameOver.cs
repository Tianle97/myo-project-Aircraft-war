using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public static GameOver _instance;
    public GUIText HighestScore;
    public GUIText CurrentScore;
       void Awake()
    {
        _instance = this;
        this.gameObject.SetActive(false);//stop game
    }
    public void Show(float Current) {
        float highestScore = PlayerPrefs.GetFloat("highestScore",0);
        //float CurrentScore = PlayerPrefs.GetFloat("CurrentScore",0);
        if (Current > highestScore) {
            PlayerPrefs.SetFloat("highestScore", Current);
        }
        HighestScore.text = highestScore + "";
        CurrentScore.text = Current + "";

        this.gameObject.SetActive(true);
    }
}
