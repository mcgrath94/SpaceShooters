using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;

    public float fireSpeed;
    public float enemyFireDelay;

    // Use this for initialization
    void Start()
    {

        InvokeRepeating("Fire", enemyFireDelay, fireSpeed);
    }


    void Fire () {

        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
	}
	
	
}
