using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_3 : MonoBehaviour
{
    public float estatura, peso;
    public bool hombre, mujer;
    private float vitaminas;
    // Start is called before the first frame update
    void Start()
    {
        if(hombre==true && mujer==false && (estatura>=1.6f && peso>=150f) )
        {
            vitaminas = (estatura * 0.2f) + (peso * 0.8f);
            Debug.Log(vitaminas);
        }
        else if (hombre == true && mujer == false && (estatura < 1.6f || peso < 150f))
        {
            vitaminas = (estatura * 0.3f) + (peso * 0.7f);
            Debug.Log(vitaminas);
        }
        if (hombre == false && mujer == true && (estatura >= 1.5f && peso >= 130f))
        {
            vitaminas = (estatura * 0.25f) + (peso * 0.75f);
            Debug.Log(vitaminas);
        }
        else if (hombre == false && mujer == true && (estatura < 1.5f || peso < 130f))
        {
            vitaminas = (estatura * 0.35f) + (peso * 0.65f);
            Debug.Log(vitaminas);
        }
        if (hombre == false && mujer == false)
        {
            Debug.Log("Porfavor seleccione un sexo");
        }
        else if (hombre == true && mujer == true)
        {
            Debug.Log("Porfavor seleccione un solo sexo");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
