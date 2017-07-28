using UnityEngine;

public class SonidosPelota : MonoBehaviour
{
    public AudioSource rebote;
    public AudioSource puntos;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bloque"))
            puntos.Play();
        else
            rebote.Play();
    }
}
