using UnityEngine;
using System.Collections;

public class EnemyDodge : MonoBehaviour {

    public Vector2 startDelay;
    private float movement;
    public float dodge;
    public Vector2 movementTime;
    public Vector2 movementDelay;
    private Rigidbody rb;

    public float smoothing;
    private float currSpeed;
    public Boundary boundary;
    public float tilt;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        currSpeed = rb.velocity.z;
        StartCoroutine(Dodge());
	
	}

    IEnumerator Dodge()
    {
        yield return new WaitForSeconds(Random.Range(startDelay.x, startDelay.y));

        while(true)
        {
            movement = Random.Range(1, dodge) * -Mathf.Sign(transform.position.x);
            yield return new WaitForSeconds(Random.Range(movementTime.x, movementTime.y));
            movement = 0;
            yield return new WaitForSeconds(Random.Range(movementDelay.x, movementDelay.y));
        }

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        float newMovement = Mathf.MoveTowards(rb.velocity.x, movement, Time.deltaTime * smoothing);
        rb.velocity = new Vector3(newMovement, 0.0f, currSpeed);
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), 0.0f, Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax));

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x - tilt);
    }
}
