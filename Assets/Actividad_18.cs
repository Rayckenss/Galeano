using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_18 : MonoBehaviour
{
    public int dividendo, divisor;
    private int cont, resultado, residuo;
    private bool bandera;
    // Start is called before the first frame update
    void Start()
    {
        resultado = dividendo;
        while (divisor<resultado)
        {
            resultado = resultado - divisor;
            cont++;
        }
        Debug.Log("El residuo es " + resultado + " y el cociente es " + cont);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
