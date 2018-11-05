using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    [Header("Propriedade")]
    public int pontos;
    public float jumpHeight;
    public float gravity;
    [Header("Imports")]
    public GameObject gameOverScreen;
    public Text ptsTxt;

    private Animator anim;
    private Rigidbody2D rb;
    private bool died = false;

	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if (died == false)
        {
            ptsTxt.text = pontos.ToString();
            transform.position -= new Vector3(0, gravity, 0);
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<AudioSource>().Play();
                rb.AddForce(new Vector3(0, jumpHeight, 0));
                anim.Play("up");
            }
        }
        if(transform.position.y > 7)
        {
            Die();
        }else if(transform.position.y < -5)
        {
            Die();
        }
    }
   

    public void addPoints()
    {
        pontos++;
    }

    public void Die()
    {
        died = true;
        Come[] canos = FindObjectsOfType<Come>();
        for(int i = 0; i < canos.Length; i++)
        {
            canos[i].speed = 0;
        }
        gameOverScreen.SetActive(true);
    }

    public void Respawn()
    {
        pontos = 0;
        Come[] canos = FindObjectsOfType<Come>();
        for (int i = 0; i < canos.Length; i++)
        {
            Destroy(canos[i].gameObject);
        }
        FindObjectOfType<CanoGenerator>().newLocation = new Vector3(0, 0, 0);
        transform.position = new Vector3(-8, 0.4f, 0);
        rb.velocity = new Vector3(0, 0, 0);
        gameOverScreen.SetActive(false);
        died = false;
    }
    
}
