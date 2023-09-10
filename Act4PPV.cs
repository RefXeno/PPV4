using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act4PPV : MonoBehaviour
{
    // El círculo grande alrededor del cual rotará el círculo mediano
    public Transform circuloGrande;

    // La velocidad de rotación del círculo mediano en grados por segundo
    public float velocidadMediana = 10f;

    // El círculo pequeño alrededor del cual rotará el círculo pequeño
    public Transform circuloPequeno;

    // La velocidad de rotación del círculo pequeño en grados por segundo
    public float velocidadPequena = 20f;

    void Update()
    {
        // Rotar el círculo mediano alrededor del círculo grande en el eje Z
        transform.RotateAround(circuloGrande.position, Vector3.forward, velocidadMediana * Time.deltaTime);

        // Rotar el círculo pequeño alrededor del círculo mediano en el eje Z
        circuloPequeno.RotateAround(transform.position, Vector3.forward, velocidadPequena * Time.deltaTime);
    }
}
