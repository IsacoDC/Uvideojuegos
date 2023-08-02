using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fruta : MonoBehaviour
{
    [SerializeField] private GameObject efecto;
    [SerializeField] private float cantidadPuntos;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            Instantiate(efecto, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
