using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [SerializeField] private GameObject balaEnemigoPrefab;
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private float tiempoEntreDisparos;
    [SerializeField] private float tiempoSiguienteDisparo;

    private void Update()
    {
        if (tiempoSiguienteDisparo > 0)
        {
            tiempoSiguienteDisparo -= Time.deltaTime;
        }
        else
        {
            Disparar();
            tiempoSiguienteDisparo = tiempoEntreDisparos;
        }
    }

    private void Disparar()
    {
        Instantiate(balaEnemigoPrefab, controladorDisparo.position, Quaternion.identity);
    }
}
