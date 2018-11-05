using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoGenerator : MonoBehaviour {

    public GameObject cano;
    public Vector3 newLocation;
    public float timeToCreate;

    private void Start()
    {
        StartCoroutine(create());
    }

    IEnumerator create()
    {
        yield return new WaitForSeconds(timeToCreate);
        float rnd = Random.Range(-1.5f, 3.5f);
        Instantiate(cano, newLocation + new Vector3(0,rnd,0), Quaternion.identity);
        newLocation.x += 10;
        StartCoroutine(create());
    }
}
