using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_20 : MonoBehaviour
{
    private int[] numeros = { 238, 48, 50, 38 };
    private int indice=0;
    public int valorDeseado;
    private bool bandera;
    // Start is called before the first frame update
    void Start()
    {
        bandera = false;
        while (indice<numeros.Length)
        {
            if (valorDeseado==numeros[indice])
            {
                bandera = true;
                indice = numeros.Length + 1;
            }
            indice++;

        }
        if (bandera)
        {
            print("numero encontrado");
        }
        else
        {
            print("numero no encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
