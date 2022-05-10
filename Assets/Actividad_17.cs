using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_17 : MonoBehaviour
{
    public int numero;
    private int proceso, resta, cont;
    // Start is called before the first frame update
    void Start()
    {
        resta = numero;
        while (cont<numero)
        {
            resta--;
            Debug.Log(resta);
            cont++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
