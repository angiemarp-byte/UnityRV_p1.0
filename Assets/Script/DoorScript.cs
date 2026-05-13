using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip abrirSonido;
    public AudioClip cerrarSonido;

    private bool abierta = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (!abierta)
            {
                transform.Rotate(0, 90, 0);

                audioSource.PlayOneShot(abrirSonido);

                abierta = true;
            }
            else
            {
                transform.Rotate(0, -90, 0);

                audioSource.PlayOneShot(cerrarSonido);

                abierta = false;
            }
        }
    }
}