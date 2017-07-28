using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public SiguienteNivel siguienteNivel;
    public GameObject gameOver;
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
        if (vidas <= 0) return;
        Vidas.vidas--;
        ActualizarMarcadorVidas();

        if (vidas <= 0)
        {
            gameOver.SetActive(true);
            pelota.DetenerMovimiento();
            barra.enabled = false;
            siguienteNivel.nivelACargar = "Portada";
            siguienteNivel.ActivarCargar();
        }
        else
        {
            barra.Reset();
            pelota.Reset();
        }
    }
}
