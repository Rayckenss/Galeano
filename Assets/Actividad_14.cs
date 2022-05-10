using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_14 : MonoBehaviour
{
    public float entradaN;
    private float suma, resultado, cont,promedio;
    // Start is called before the first frame update
    void Start()
    {
        resultado = 0;
        cont = 0;
        while (cont<entradaN)
        {
            resultado = resultado + (resultado+1);
            cont++;
        }
        promedio = resultado / entradaN;
        Debug.Log("la suma es "+resultado);
        Debug.Log("el promedio es "+promedio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
