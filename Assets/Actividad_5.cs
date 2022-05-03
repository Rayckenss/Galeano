using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_5 : MonoBehaviour
{
    [Header("Actividad 4")]
    public float minutos, horas;
    private float tiempoTotal, precio;
    public bool martes, sabado;
    // Start is called before the first frame update
    void Start()
    {
        //Actividad 4
        tiempoTotal = (horas / 60f) + (horas % 60f) + minutos;

        if (martes == true || sabado == true && tiempoTotal > 10f)
        {
            precio = (tiempoTotal * 0.1f) - ((tiempoTotal * 0.1f) * .1256f);
            Debug.Log("Cancela" + precio);
        }
        else if (martes == false && sabado == false && tiempoTotal > 10f)
        {
            precio = (tiempoTotal * 0.1f);
            Debug.Log("Cancela " + precio);
        }
        else if (tiempoTotal <= 10f)
        {
            Debug.Log("Es gratis");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
