using UnityEngine;

public class Barra : MonoBehaviour
{
    public ElementoInterativo botonIzquierda;
    public ElementoInterativo botonDerecho;
    public float velocidad = .4f;

    Vector3 posIncial;
	
	void Start ()
    {
        posIncial = transform.position;
	}
	
	void Update ()
    {
        float direccion = botonIzquierda.pulsado ? -1: (botonDerecho.pulsado ? 1: Input.GetAxisRaw("Horizontal"));
        float posX = transform.position.x + (direccion * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y, transform.position.z);
	}

    public void Reset()
    {
        transform.position = posIncial;
    }
}
