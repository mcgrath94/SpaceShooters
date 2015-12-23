using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject[] hazards;
    public int hazardCount;
    public Vector3 spawnValues;
    public float spawnDelay;
    public float startDelay;
    public float waveDelay;

    public GUIText scoreText;
    private int score;

    public bool gameOver;

    void Start()
    {
        gameOver = false;
        score = 0;
        UpdateScore();

        StartCoroutine (SpawnWaves());
    }

    void Update()
    {
        if(gameOver == true)
        {
           
            Application.LoadLevel(2);
        }
    }

    public void GameOver()
    {
        gameOver = true;
    }


    IEnumerator SpawnWaves()
    {
        int i;
        yield return new WaitForSeconds(startDelay);
        while (true)
        {
            for (i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];

                Vector3 spawnPosition = new Vector3(Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnDelay);
            }
            yield return new WaitForSeconds(waveDelay);

          
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }



    void UpdateScore()
    {
        scoreText.text = "Score: " + score;

        PlayerPrefs.SetInt("SavedScore", score);
    }
 

}
