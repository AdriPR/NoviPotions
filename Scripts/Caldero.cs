using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caldero : MonoBehaviour
{
    public bool rojo;
    public bool verde;
    public bool azul;
    public AudioSource splash;
    public GameObject posicionOriginal;

    private void OnTriggerEnter(Collider col)
    {
        
        IngredienteColor aux = col.GetComponent<IngredienteColor>();
        if (aux.rojo)
        {
            rojo = aux.rojo;
        }else if (aux.verde)
        {
            verde = aux.verde;
        }else if (aux.azul)
        {
            azul = aux.azul;
        }

   
    }

    private void OnCollisionEnter(Collision collision)
    {
        splash.Play();
        collision.gameObject.SetActive(false);
        collision.gameObject.transform.position = posicionOriginal.transform.position;

    }
}
