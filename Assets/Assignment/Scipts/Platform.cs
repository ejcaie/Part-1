using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Player_ player;

    //Tests if the player is touching the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.ground = 1;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        player.ground = 0;
    }
}

