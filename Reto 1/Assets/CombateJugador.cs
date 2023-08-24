using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CombateJugador : MonoBehaviour
{
    [SerializeField] private int vida;
    public event EventHandler MuerteJugador;
    public void TomarDa�o(int cantidadDa�o)
    {
        vida -= cantidadDa�o;
        if (vida <= 0)
        {
            MuerteJugador?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        }
    }
}