using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnIngrediente : MonoBehaviour
{

    public Animator noviAnimator;
    public Button boton;

    public void spawnIngrediente(GameObject ingrediente)
    {
        ingrediente.SetActive(true);
        
        
    }

    void Update()
    {
        if(noviAnimator.GetBool("botones"))
        {
            boton.interactable = true;
        }
        if (noviAnimator.GetBool("desactivarBotones"))
        {
            boton.interactable = false;
        }
    
    }
}
