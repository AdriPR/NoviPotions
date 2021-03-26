using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mezclar : MonoBehaviour
{
    public GameObject cal;
    public GameObject ped;
    public GameObject activarPed;
    public Animator noviAnim;
    public ParticleSystem particulas;
    private ParticleSystem.MainModule ma;
    public int aciertos;
    public int fallos;

    public void novi(GameObject n)
    {
        n.GetComponent<Animator>().SetBool("mezcla", true);

        Caldero caldero = cal.GetComponent<Caldero>();
        IngredienteColor pedido = ped.GetComponent<IngredienteColor>();

        if (caldero.rojo == pedido.rojo && caldero.verde == pedido.verde && caldero.azul == pedido.azul)
        {
            aciertos++;
            n.GetComponent<Animator>().SetBool("goodPotion", true);
        }
        else
        {
            fallos++;
        }

        colorParticulas();
        caldero.rojo = false;
        caldero.verde = false;
        caldero.azul = false;

        
    }

    void Start()
    {
        ma = particulas.main;
    }

    void Update()
    {
        if (noviAnim.GetBool("mezcla"))
        {
            activarPed.SetActive(false);
        }else if (!noviAnim.GetBool("mezcla"))
        {
            GetComponent<Button>().interactable = true;
            activarPed.SetActive(true);
        }

        if (noviAnim.GetBool("particulas"))
        {
            
            noviAnim.SetBool("particulas", false);
            particulas.Play();
        }
    }

    private void colorParticulas()
    {

        if (noviAnim.GetBool("goodPotion"))
        {
            if (cal.GetComponent<Caldero>().rojo && cal.GetComponent<Caldero>().verde)
            {
                ma.startColor = new Color(1, 1, 0);
            }
            if (cal.GetComponent<Caldero>().rojo && cal.GetComponent<Caldero>().azul)
            {
                ma.startColor = new Color(1, 0, 1);
            }
            if (cal.GetComponent<Caldero>().verde && cal.GetComponent<Caldero>().azul)
            {
                ma.startColor = new Color(0, 1, 1);
            }
        }
        if (!noviAnim.GetBool("goodPotion"))
        {
            ma.startColor = new Color(0.7f, 0.7f, 0.7f);
        }


    }
}
