using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CuentaAtras : MonoBehaviour
{

    public float tiempo = 5.0f;
    public Text comienzo;
    public GameObject ready;
    public GameObject tablaPuntuacion;

    private int minutos;
    private int segundos;
    private string segundosString;

    void Update()
    {
        if (!ready.activeSelf && tiempo > 0)
        {
            minutos = (int)tiempo / 60;
            segundos = (int)tiempo % 60;
            if (segundos < 10)
            {
                segundosString = "0" + segundos.ToString();
            }
            else
            {
                segundosString = segundos.ToString();
            }
            comienzo.text = minutos.ToString() + ":" + segundosString;

            tiempo = tiempo - Time.deltaTime;

            if (tiempo < 0)
            {
                tablaPuntuacion.SetActive(true);
            }
        }
        
    }
}
