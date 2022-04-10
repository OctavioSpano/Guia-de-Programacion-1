using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    // Start is called before the first frame update
    public int numero;
    void Start()
    {
        bool estaEnA,estaEnB, estaEnAmbos, noEstaEnNinguno;
            
        if (numero < 10 && numero > -10)
        {
            if (numero % 2 == 0)
            {
                estaEnAmbos = true;
                Debug.Log("Está en ambos: " + estaEnAmbos);
            }

            else
            {
                estaEnA = true;
                Debug.Log("Está en A: " + estaEnA);

            }
        }

        else if (numero % 2 == 0)
        {
            estaEnB = true;
            Debug.Log("Está en B: " + estaEnB);
        }

        else
        {
            noEstaEnNinguno = true;
            Debug.Log("No está en ninguno: " + noEstaEnNinguno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
