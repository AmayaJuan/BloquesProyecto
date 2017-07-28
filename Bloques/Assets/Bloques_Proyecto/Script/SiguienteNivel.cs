using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour
{
    public string nivelACargar;
    public float retraso;

    [ContextMenu("Activar Cargar")]
    public void ActivarCargar()
    {
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel()
    {
        if (!EsUltimoNivel())
        {
            Vidas.vidas++;
        }
        SceneManager.LoadScene(nivelACargar);
    }

    public bool EsUltimoNivel()
    {
        return nivelACargar == "Portada";
    }
}
