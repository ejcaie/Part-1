using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ : MonoBehaviour
{

    public float force = 500f;
    public Vector2 position;
    public int ground;
    public float score = 0f;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        ground = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Allows player to move horizontally
        position.x = Input.GetAxis("Horizontal");
        //If the player touches the ground, causes them to jump
        if (ground != 0)
        {
            position.y = 75;
        }
        else
        {
            position.y = 0;
        }
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(force * position * Time.deltaTime);
    }
}
