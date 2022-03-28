using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    //8. Crear una variable entera que pueda ser modificada desde el Inspector. Suponiendo que
    //el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
    //valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
    //mensaje de error "El día ingresado no es válido".
    public int dia;
    void Start()
    {
        if (dia == 1)
        {
            Debug.Log ("El día es Domingo");
        }
        if (dia == 2)
        {
            Debug.Log ("El día es Lunes");
        }
         if (dia == 3)
        {
            Debug.Log ("El día es Martes");
        }
         if (dia == 4)
        {
            Debug.Log ("El día es Miércoles");
        }
         if (dia == 5)
        {
            Debug.Log ("El día es Jueves");
        }
         if (dia == 6)
        {
            Debug.Log ("El día es Viernes");
        }
         if (dia == 7)
        {
            Debug.Log ("El día es Sábado");
        }
         if (dia > 7)
        {
            Debug.Log ("El día ingresado no es válido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
