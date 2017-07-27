using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPuntos;
	
	void Start ()
    {
        ActualizarMarcadorPuntos();
	}
	
    void ActualizarMarcadorPuntos()
    {
        textoPuntos.text = "Puntos: " + Puntos.puntos;
    }

	public void GanarPuntos()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();
    }
}
