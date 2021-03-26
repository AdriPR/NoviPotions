using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredienteColor : MonoBehaviour
{
    public bool rojo;
    public bool verde;
    public bool azul;

    public void resetIngrediente()
    {
        rojo = false;
        verde = false;
        azul = false;
    }
}
