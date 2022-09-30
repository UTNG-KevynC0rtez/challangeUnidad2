/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion del Script: Este Script es para que al presionar el boton de espacio aparezca un perro
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
