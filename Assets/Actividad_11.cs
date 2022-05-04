using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_11 : MonoBehaviour
{
    public float valorM, valorN, valorQ;
    private float resultado, resultado1, resultado2, resultado3;
    // Start is called before the first frame update
    void Start()
    {
         resultado = ((valorM * valorM * valorM * valorM) - (valorN * valorN * valorN) + (4 * (valorQ * valorQ)));
        if (resultado<820f)
        {
            Debug.Log(resultado + "<820");
        }
        else
        {
            Debug.Log(resultado + ">820");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
