using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Player_ player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Increases score by 1 and removes score trigger
        player.score = player.score + 1;
        Destroy(gameObject);
    }
}
