using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public GameObject efectoParticulas;

    void OnCollisionEnter(Collision other)
    {
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
