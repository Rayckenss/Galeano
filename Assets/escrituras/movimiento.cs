using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {

        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoH, 0.9f, movimientoV);
        rb.AddForce(movimiento * velocidad * Time.deltaTime);

    }
}
