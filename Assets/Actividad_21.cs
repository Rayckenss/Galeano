using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad_21 : MonoBehaviour
{
    public float maxLife = 100;
    public float currentLife;
    private void Start()
    {
        currentLife = maxLife;
    }
    public void GetDamage (float damage)
    {
        //Recibir Daño
        currentLife = currentLife - damage;
        if (currentLife<=0)
        {
            gameObject.SetActive(false);
        }
    }
}
