﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    // 7. Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y
    //num3, muestre el valor del mayor de todos.
    //En caso de igualdad entre los tres imprimir "Los números son iguales".
    //Test1: num1 = 12, num2 = 4, num3= 7. Resultado esperado: El mayor número es num1 Test2: num1
    //= 2, num2 = 65, num3= 8. Resultado esperado: El mayor número es num2
    //Test3: num1 = 3, num2 = 10, num3= 28. Resultado esperado: El mayor número es num3
    //Test4: num1 = 5, num2 = 5, num3= 5. Resultado esperado: Los números son iguales
    public int num1, num2, num3;
    void Start()
    {
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log ("El mayor número es num1 ("+num1+")");
        }
        if (num2 > num1 && num2 > num3)
        {
            Debug.Log ("El mayor número es num2 ("+num2+")");
        }
        if (num3 > num2 && num3 >num1)
        {
            Debug.Log ("El mayor número es num3 ("+num3+")");
        }
        if (num1 == num2 && num2 == num3)
        {
            Debug.Log ("Los números son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
