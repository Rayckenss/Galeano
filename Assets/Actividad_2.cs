using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_2 : MonoBehaviour
{
    public float valorNeto;
    private float valorTotal;
    public bool azul;
    public bool rojo;
    public bool blanco;
    // Start is called before the first frame update
    void Start()
    {
        if (azul == true && rojo==false && blanco==false)
        {
            valorTotal = valorNeto - (valorNeto * 0.2f);
            Debug.Log(valorTotal);
        }
        else if (rojo == true && azul==false && blanco==false)
        {
            valorTotal = valorNeto - (valorNeto * 0.3f);
            Debug.Log(valorTotal);
        }
        else if(blanco == true && azul==false && rojo==false)
        {
            valorTotal = valorNeto;
            Debug.Log(valorTotal);
        }
        else
        {
            Debug.Log("Porfavor seleccionar solo una bolita");
        }
        
    }


}
