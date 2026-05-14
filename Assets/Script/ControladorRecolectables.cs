using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorRecolectables : MonoBehaviour
{
    public TextMeshProUGUI textoContador;

    public int TotalRecolectables = 0;

    private void Awake()
    {
        textoContador.text = TotalRecolectables.ToString();
    }
    [ContextMenu("Incrementar Contador")]
    public void IncrementarContador()
    {
        TotalRecolectables++;
        textoContador.text = TotalRecolectables.ToString();
    }
}
