using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avtividad_4 : MonoBehaviour
{
    [Header("Actividad 3")]
    public bool mallasPlanas, mallasRollo;
    public float tiempoDias, tiempoMeses, tiempoAnos, cantidad;
    private float precioTotal, anosTotales;
    




    // Start is called before the first frame update
    void Start()
    {
        //Actividad 3
        anosTotales = (tiempoDias / 365f) + (tiempoMeses / 12f) + tiempoAnos;
        if(mallasPlanas==true)
        {
            if(anosTotales>=5f)
            {
                precioTotal = (cantidad * 400f) - ((cantidad * 400f) * 0.08f);
                Debug.Log(precioTotal);
            }
            else
            {
                precioTotal = (cantidad * 400f);
                Debug.Log(precioTotal);
            }
        }
        else if (mallasRollo==true)
        {
            if (anosTotales>=6f)
            {
                precioTotal = (cantidad * 250f) - ((cantidad * 250f) * 0.06f);
                Debug.Log(precioTotal);
            }
            else
            {
                precioTotal = (cantidad * 250f) ;
                Debug.Log(precioTotal);
            }
        }

 

    }

  
}
