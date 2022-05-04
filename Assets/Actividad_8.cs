using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_8 : MonoBehaviour
{
    public string nombre;
    private string nombreTienda = "TodoSillas";
    public int tipoA, tipoB, tipoC;
    private float precioUnitario, precioTotal, precioNeto, precioA, precioB, precioC;
    // Start is called before the first frame update
    void Start()
    {
        if (tipoA >= 5)
        {
            precioA = (tipoA * 5f) - ((tipoA * 5f) * 0.03f);
        }
        else
        {
            precioA = (tipoA * 5f);
        }
        if (tipoB >= 5)
        {
            precioB = (tipoB * 7f) - ((tipoB * 7f) * 0.05f);
        }
        else
        {
            precioB = (tipoB * 7f);
        }
        if (tipoC >= 5)
        {
            precioC = (tipoC * 10f) - ((tipoC * 10f) * 0.07f);
        }
        else
        {
            precioC = (tipoC * 10f);
        }
        Debug.Log(nombreTienda);
        Debug.Log("Cliente " + nombre);
        Debug.Log("Producto -- Cantidad -- Precio Unitario");
        if (tipoA > 0)
        {
            Debug.Log("Silla tipo A " + tipoA + " $5.00");
        }
        else { }
        if (tipoB > 0)
        {
            Debug.Log("Silla tipo B " + tipoB + " $7.00");
        }
        else { }
        if (tipoC > 0)
        {
            Debug.Log("Silla tipo C " + tipoC + " $10.00");
        }
        else { }
        precioTotal = (tipoA * 5f) + (tipoB * 7f) + (tipoC * 10f);
        precioNeto = precioA + precioB + precioC;
        precioUnitario = ((tipoA * 5f) * 0.03f) + ((tipoB * 7f) * 0.05f) + ((tipoC * 10f) * 0.07f);
        float descuento = precioTotal - precioNeto;
        Debug.Log("Total a neto "+ "$"+precioTotal);
        Debug.Log("Total descuento "+"$"+descuento );
        Debug.Log("Total a Pagar " +"$"+ precioNeto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
