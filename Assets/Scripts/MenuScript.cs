using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 100, 40), "Space Shooters!");

        if (GUI.Button(new Rect(Screen.width / 2 - 30, 350, 60, 30), "Play"))
        {
            Application.LoadLevel(0);
        }
        
    }
	
}
