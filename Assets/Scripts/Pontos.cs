using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        FindObjectOfType<Player>().addPoints();
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
