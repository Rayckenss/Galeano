using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_9 : MonoBehaviour
{
    public int numero;

    // Start is called before the first frame update
    void Start()
    {
        if (numero > 0)
        {
            Debug.Log("positivo");
        }
        else if (numero<0)
        {
            Debug.Log("negativo");
        }
        else
        {
            Debug.Log("nulo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
