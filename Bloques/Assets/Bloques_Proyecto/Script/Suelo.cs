﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Vidas vidas;

    void OnTriggerEnter(Collider other)
    {
        vidas.PerderVida();
    }
}
