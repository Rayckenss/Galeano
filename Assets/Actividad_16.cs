using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_16 : MonoBehaviour
{
    public int numeroM, numeroN;
    private int multiplo, cont;
    // Start is called before the first frame update
    void Start()
    {
        multiplo = 0;
        cont = 0;
        while (multiplo<numeroN)
        {
            multiplo = multiplo + numeroM;
            Debug.Log(multiplo);
            cont++;
        }
        Debug.Log("entre M y N hay " + cont + " multiplos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
