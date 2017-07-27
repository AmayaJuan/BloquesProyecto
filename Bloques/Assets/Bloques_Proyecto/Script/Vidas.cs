using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public Pelota pelota;
    public Barra barra;
    public static int vidas = 3;
    public Text textoVidas;

	void Start ()
    {
        ActualizarMarcadorVidas();
    }

    void ActualizarMarcadorVidas()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }
	
    public void PerderVida()
    {
        Vidas.vidas--;
        ActualizarMarcadorVidas();

        barra.Reset();
        pelota.Reset();
    }
}
