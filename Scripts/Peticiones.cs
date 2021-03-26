using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Peticiones : MonoBehaviour
{

    public GameObject p;
    private IngredienteColor peticion;
    private RawImage colorPeticion;
    public Animator noviAnimator;


    // Start is called before the first frame update
    void Start()
    {
        peticion = p.GetComponent<IngredienteColor>();
        colorPeticion = p.GetComponent<RawImage>();
        generarPeticion();

    }

    // Update is called once per frame
    void Update()
    {
        if (noviAnimator.GetBool("nuevaPeticion"))
        {
            peticion.resetIngrediente();
            generarPeticion();
            noviAnimator.SetBool("nuevaPeticion", false);
        }
        
    }

    private void generarPeticion()
    {
        float probabilidad = Random.value;
        if(probabilidad <= 0.33)
        {
            peticion.rojo = true;
            peticion.verde = true;
        }else if(probabilidad > 0.33 && probabilidad <= 0.66)
        {
            peticion.rojo = true;
            peticion.azul = true;
        }else if(probabilidad > 0.66)
        {
            peticion.verde = true;
            peticion.azul = true;
        }


        if (peticion.rojo && peticion.verde)
        {
            colorPeticion.color = new Color(1, 1, 0);
        }
        if (peticion.rojo && peticion.azul)
        {
            colorPeticion.color = new Color(1, 0, 1);
        }
        if (peticion.verde && peticion.azul)
        {
            colorPeticion.color = new Color(0, 1, 1);
        }
    }
}
