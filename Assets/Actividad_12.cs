using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_12 : MonoBehaviour
{
    public int cantidadN;
    private int resultado, suma;
    // Start is called before the first frame update
    void Start()
    {
        resultado = 0;
        suma = 1;
        while (cantidadN<=5)
        {
            resultado = resultado + suma;
            suma++;
            cantidadN++;
            Debug.Log(resultado);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
