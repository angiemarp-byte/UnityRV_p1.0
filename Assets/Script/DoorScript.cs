using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private bool abierta = false;

    private Quaternion cerradaRotacion;
    private Quaternion abiertaRotacion;

    void Start()
    {
        cerradaRotacion = Quaternion.Euler(0, 0, 0);
        abiertaRotacion = Quaternion.Euler(0, 90, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Intentando abrir/cerrar");

            abierta = !abierta;

            transform.rotation = abierta
                ? abiertaRotacion
                : cerradaRotacion;
        }
    }
}