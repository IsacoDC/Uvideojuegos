using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Item-feedback-Animation"))
        {
            // Si la animación ha terminado de reproducirse, destruye el objeto.
            Destroy(gameObject);
        }
    }
}

