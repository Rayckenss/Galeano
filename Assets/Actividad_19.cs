using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_19 : MonoBehaviour
{
    int[] edades = { 24, 18, 20, 25 };
    private int indice=0;
    private int suma, promedio;
    // Start is called before the first frame update
    void Start()
    {
        while (indice<edades.Length)
        {
            suma = suma + edades[indice];
            indice++;
            print(suma);
        }
        promedio = suma / indice;
        print("el pormedio es "+promedio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
