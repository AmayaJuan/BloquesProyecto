using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = .4f;

    Vector3 posIncial;
	
	void Start ()
    {
        posIncial = transform.position;
	}
	
	void Update ()
    {
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y, transform.position.z);
	}

    public void Reset()
    {
        transform.position = posIncial;
    }
}
