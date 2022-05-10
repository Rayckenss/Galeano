using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_13 : MonoBehaviour
{
   
    public int numeroN;
    private int resultado, suma, cont;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
        suma = 1;
        resultado = 0;
        while (cont<numeroN)
        {
            resultado = resultado + suma;
            suma += 2;
            cont++;
        }
        Debug.Log(resultado);
    }
}
