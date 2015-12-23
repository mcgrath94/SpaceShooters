using UnityEngine;
using System.Collections;

public class HighScoreScript : MonoBehaviour {

    public int highScore;
    public int highScore2;
    public int highScore3;
    public int highScore4;
    public int highScore5;


    void Awake()
    {

        highScore = PlayerPrefs.GetInt("HighScore");

        highScore2 = PlayerPrefs.GetInt("HighScore2");

        highScore3 = PlayerPrefs.GetInt("HighScore3");

        //highScore4 = PlayerPrefs.GetInt("HighScore4");

        //highScore5 = PlayerPrefs.GetInt("HighScore5");
        
    }

    void OnGUI()
    {

        GUI.Label(new Rect(Screen.width/2, (Screen.height/8*2), 200, 50), "1: " + highScore);

        GUI.Label(new Rect(Screen.width/2, (Screen.height / 8 * 3), 200, 50), "2: " + highScore2);

        GUI.Label(new Rect(Screen.width/2, (Screen.height / 8 * 4), 200, 50), "3: " + highScore3);

        //GUI.Label(new Rect(600, 250, 200, 50), "4: " + highScore4);

        //GUI.Label(new Rect(600, 300, 200, 50), "5: " + highScore5);

    }
} 
