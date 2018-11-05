using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Come : MonoBehaviour {

    public float speed;
    public bool passado;

	void Update () {
        transform.position -= new Vector3(speed, 0, 0);
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
