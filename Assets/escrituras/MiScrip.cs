using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MiScrip : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public int edad1;
    public int edad2;

    // Start is called before the first frame update
    void Start()
    {
        int resultado = edad1 + edad2;
        Debug.Log("hola mi nombre es " + nombre1 + " y tengo " + edad1 + " a�os. ");
        Debug.Log("Mi compa�ero es " + nombre2 + " y el tiene " + edad2 + " a�os. ");
        Debug.Log("La suma de nuestras edades es " + resultado + " a�os.");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
