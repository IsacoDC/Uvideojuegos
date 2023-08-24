using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            Destroy(collision.gameObject);
        }
    }
}
public class BalaEnemigo : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private int daño;
    [SerializeField] private float tiempoDeVida;

    private void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }
    private void Update()
    {
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<CombateJugador>().TomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
