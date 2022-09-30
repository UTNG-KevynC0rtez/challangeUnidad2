/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion del Script: Este Script es para el movimiento del perro, este se movera en linea recta
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Es para el movimiento del perro, este se movera en su eje
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
