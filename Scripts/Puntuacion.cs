using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{

    public Mezclar puntuaciones;
    public CuentaAtras c;
    public Text numAciertos;
    public Text numFallos;
    public Text total;
    public Text totalAciertos;
    public Text totalFallos;

    void Update()
    {
        if (c.tiempo <= 0 && c.tiempo < 20)
        {
            c.tiempo = -21.0f;
            generarPuntuacion();
        }
    }

    private void generarPuntuacion()
    {
        numAciertos.text = puntuaciones.aciertos.ToString();
        numFallos.text = puntuaciones.fallos.ToString();
        int tA = puntuaciones.aciertos * 10;
        int tF = puntuaciones.fallos * -5;
        int t = tA + tF;
        totalAciertos.text = tA.ToString();
        totalFallos.text = tF.ToString();
        total.text = t.ToString();

    }
}
