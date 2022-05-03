using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_6 : MonoBehaviour
{
    public float valorUno, valorDos;
    public string codigo;
    private float respuesta;

    // Start is called before the first frame update
    void Start()
    {
        if (codigo=="1")
        {
            respuesta = valorUno + valorDos;
            Debug.Log(respuesta);
        }
        else if (codigo=="2")
        {
            respuesta = valorUno - valorDos;
            Debug.Log(respuesta);
        }
        else if (codigo=="3")
        {
            respuesta = valorUno * valorDos;
            Debug.Log(respuesta);
        }
        else if (codigo=="4")
        {
            respuesta = valorUno / valorDos;
            Debug.Log(respuesta);
        }
        else
        {
            Debug.Log("Error");
        }
    }

}
