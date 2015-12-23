using UnityEngine;
using System.Collections;

public class AsteroidDestroyer : MonoBehaviour {

    public GameObject explosian;
    public GameObject playerExplosian;

    public int scoreValue;
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        else if (gameController == null)
        {
            Debug.Log("Cannot find script");
        }


    }

    void OnTriggerEnter(Collider other) { 
       if(other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        if (explosian != null)
        {
            Instantiate(explosian, transform.position, transform.rotation);
        }

        if (other.tag == "Player")
        {
            Instantiate(playerExplosian, other.transform.position, other.transform.rotation);

            gameController.GameOver();
        }

        gameController.AddScore (scoreValue);

        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
