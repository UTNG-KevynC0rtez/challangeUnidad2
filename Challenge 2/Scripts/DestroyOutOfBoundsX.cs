/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion del Script: Este Script es para que los perros y las pelotas, estos seran destruidos cuando lleguen a los limites del
* juego, para los perros su limite es de -40, y para las pelotas su limite es -5.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
