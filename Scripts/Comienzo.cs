using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comienzo : MonoBehaviour
{
    public float tiempo = 5.0f;
    public Text comienzo;
    public GameObject panelComienzo;
    
    void Update()
    {
        tiempo = tiempo - Time.deltaTime;
        comienzo.text = (tiempo).ToString("0");
        if (tiempo < 0)
        {
            panelComienzo.SetActive(false);
        }
    }
}
