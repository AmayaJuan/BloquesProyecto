using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementoInterativo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pulsado;

    public void OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }
}
