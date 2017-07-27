using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidadInicial = 600f;

    bool enJuego;
    Vector3 posIncial;
    Transform barra;
    Rigidbody rig;
   
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
        barra = GetComponentInParent<Transform>();
    }

    void Start ()
    {
        posIncial = transform.position;
    }
	
	void Update ()
    {
        if (!enJuego && Input.GetButtonDown("Fire1"))
        {
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));
        }
	}

    public void Reset()
    {
        transform.position = posIncial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
    }

    public void DetenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }
}
