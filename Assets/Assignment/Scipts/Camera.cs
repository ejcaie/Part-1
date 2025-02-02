using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Causes the camera to pan up slowly
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
