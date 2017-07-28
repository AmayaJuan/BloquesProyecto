using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour
{
    public ElementoInterativo pantalla;

	void Update ()
    {
        if (Input.GetButtonDown("Fire1") || pantalla.pulsado)
        {
            Puntos.puntos = 0;
            Vidas.vidas = 3;
            SceneManager.LoadScene("Nivel01");
        }
	}
}
