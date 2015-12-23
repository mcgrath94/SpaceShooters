using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    Text text1;
    int y;
    int z;

	void Awake()
    {
        text1 = GetComponent<Text>();
    }

    void Update()
    {
        int x = PlayerPrefs.GetInt("SavedScore");
        text1.text = "Score: " + x;


        if (x > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.GetInt("HighScore2");
            y = PlayerPrefs.GetInt("HighScore2");
            PlayerPrefs.GetInt("HighScore3");
            PlayerPrefs.SetInt("HighScore3", y);

            PlayerPrefs.GetInt("HighScore");
            z = PlayerPrefs.GetInt("HighScore");
            PlayerPrefs.GetInt("HighScore2");
            PlayerPrefs.SetInt("HighScore2", z);
                    

            PlayerPrefs.GetInt("HighScore");
            PlayerPrefs.SetInt("HighScore", x);


        }

        else if (x > PlayerPrefs.GetInt("HighScore2") && x < PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.GetInt("HighScore2");
            y = PlayerPrefs.GetInt("HighScore2");
            PlayerPrefs.GetInt("HighScore3");
            PlayerPrefs.SetInt("HighScore3", y);



            PlayerPrefs.GetInt("HighScore2");
            PlayerPrefs.SetInt("HighScore2", x);

            



        }

        else if (x > PlayerPrefs.GetInt("HighScore3") && x < PlayerPrefs.GetInt("HighScore2"))
        {

            PlayerPrefs.GetInt("HighScore3");
            PlayerPrefs.SetInt("HighScore3", x);

        }

        /*else if (x > PlayerPrefs.GetInt("HighScore4") && x < PlayerPrefs.GetInt("HighScore3"))
        {

            PlayerPrefs.GetInt("HighScore4");
            PlayerPrefs.SetInt("HighScore4", x);

        }

        else if (x > PlayerPrefs.GetInt("HighScore5") && x < PlayerPrefs.GetInt("HighScore4"))
        {

            PlayerPrefs.GetInt("HighScore5");
            PlayerPrefs.SetInt("HighScore5", x);

        }*/
    }

}
