using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{

    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destoys the player on contact
        Destroy(player);
    }
}
