using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_10 : MonoBehaviour
{
    public float cantidadMaderaA, cantidadMaderaB, cantidadMaderaC, precioA, precioB, precioC;
    private float cantidadTotal, calculoA,calculoB,calculoC;

    // Start is called before the first frame update
    void Start()
    {
        cantidadTotal = cantidadMaderaA + cantidadMaderaB + cantidadMaderaC;
        if(cantidadTotal>=30f)
        {
            calculoA = (cantidadMaderaA * precioA) - ((cantidadMaderaA * precioA) * 0.04f);
            calculoB = (cantidadMaderaB * precioB) - ((cantidadMaderaB * precioB) * 0.08f);
            calculoC = (cantidadMaderaC * precioC) - ((cantidadMaderaC * precioC) * 0.1f);
        }
        else
        {
            calculoA = (cantidadMaderaA * precioA);
            calculoB = (cantidadMaderaB * precioB);
            calculoC = (cantidadMaderaC * precioC);
        }
        Debug.Log("Total de precio a pagar " + "$" + cantidadTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
