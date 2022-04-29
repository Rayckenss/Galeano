using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamara : MonoBehaviour
{
    public GameObject bolita;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - bolita.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = bolita.transform.position + offset;
    }
}
