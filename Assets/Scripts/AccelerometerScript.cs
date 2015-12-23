using UnityEngine;
using System.Collections;

public class AccelerometerScript : MonoBehaviour {

    public Boundary boundary;

    float speed = 10;
    float tilt = 5;
    Vector3 noAccel;
    Vector3 currentAccel;
    float sensH = 10;
    float sensV = 10;
    float smooth = 0.5f;
    float GetAxisH = 0;
    float GetAxisV = 0;


    void Start()
    {
        noAccel = Input.acceleration;
        currentAccel = Vector3.zero;
    }

    void Update()
    {
        currentAccel = Vector3.Lerp(currentAccel, Input.acceleration - noAccel, Time.deltaTime / smooth);
        GetAxisV = Mathf.Clamp(currentAccel.y * sensV, -1, 1);
        GetAxisH = Mathf.Clamp(currentAccel.x * sensH, -1, 1);


        float translation = GetAxisH * speed;
        float translation2 = GetAxisV * speed;
        translation *= Time.deltaTime;
        translation2 *= Time.deltaTime;

        transform.Translate(translation, 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax), 0.0f, Mathf.Clamp(transform.position.z, boundary.zMin, boundary.zMax));

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, transform.position.x * -tilt);


    }
}

