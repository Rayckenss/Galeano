using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_22 : MonoBehaviour
{
    public float damage;
    public float damageArea;
    public Actividad_21[] enemy;
    private int indice = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);

        while (indice<enemy.Length)
        {
            if (Vector3.Distance(transform.position, enemy[indice].transform.position)<damageArea)
            {
                enemy[indice].GetDamage(damage);                
            }

            indice++;
        }
        indice = 0;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
