using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimationEvent : MonoBehaviour
{
    public void DestroyObject()
    {
        // Llamado cuando la animaci�n termine y el evento sea activado.
        Destroy(gameObject);
    }
}
