using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_7 : MonoBehaviour
{
    public float horasTrabajadas;
    private float salarioTotal;
    public bool claseA, claseB, claseC, claseD;
    // Start is called before the first frame update
    void Start()
    {
        if (claseA==true&&claseB==false&&claseC==false&&claseD==false)
        {
            salarioTotal = horasTrabajadas * 7f;
            Debug.Log("El saldo a pagar es " + salarioTotal);
        }
        else if (claseA == false && claseB == true && claseC == false && claseD == false)
        {
            salarioTotal = horasTrabajadas * 5f;
            Debug.Log("El saldo a pagar es " + salarioTotal);
        }
        else if (claseA == false && claseB == false && claseC == true && claseD == false)
        {
            salarioTotal = horasTrabajadas * 4f;
            Debug.Log("El saldo a pagar es " + salarioTotal);
        }
        else if (claseA == false && claseB == false && claseC == false && claseD == true)
        {
            salarioTotal = horasTrabajadas * 3.5f;
            Debug.Log("El saldo a pagar es " + salarioTotal);
        }
        else
        {
            Debug.Log("Porfavor seleccionar solo una clase");
        }
    }
}
