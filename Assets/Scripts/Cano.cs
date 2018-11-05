using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour {
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Player>().Die();
    }
}
