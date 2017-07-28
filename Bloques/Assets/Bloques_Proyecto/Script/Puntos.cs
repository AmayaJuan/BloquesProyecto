using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public SiguienteNivel siguienteNivel;
    public SonidosFinPartida sonidosFinPartida;
    public Pelota pelota;
    public Barra barra;
    public GameObject nivelCompletado;
    public GameObject juegoCompletado;
    public Text textoPuntos;
    public Transform contenedorBloques;
	
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

        if (contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            barra.enabled = false;

            if (siguienteNivel.EsUltimoNivel())
                juegoCompletado.SetActive(true);
            else
                nivelCompletado.SetActive(true);

            sonidosFinPartida.NivelCompletado();
            siguienteNivel.ActivarCargar();
        }
    }
}
