using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_15 : MonoBehaviour
{
    public float inversion;
    private float years, suma, capital, interes, cont;
    private bool bandera;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
        capital = 0;
        bandera = true;
        while (cont<10)
        {
            if (bandera)
            {
                capital = capital + inversion;
                interes = capital + (capital * 0.2f);
                years++;
                Debug.Log(interes+" año "+years);
                bandera = false;
                cont++;
            }
            else
            {
                suma = interes + (interes * 0.2f);
                years++;
                Debug.Log(suma + " año " + years);
                bandera = true;
                cont++;
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
