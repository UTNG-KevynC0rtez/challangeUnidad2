/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion del Script: Este Script es para detectar las colisiones entre el perro y la pelota
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
