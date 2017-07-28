using UnityEngine;

public class Pelota : MonoBehaviour
{
    public ElementoInterativo pantalla;
    public float velocidadInicial = 600f;
    public Transform barra;

    bool enJuego;
    Vector3 posIncial;
    Rigidbody rig;
   
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Start ()
    {
        posIncial = transform.position;
    }
	
	void Update ()
    {
        if (!enJuego && (Input.GetButtonDown("Fire1") || pantalla.pulsado))
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
