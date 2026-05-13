using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioClip sonidoRecolectar;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(
                sonidoRecolectar,
                transform.position
            );

            Destroy(gameObject);
        }
    }
}