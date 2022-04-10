using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    // Start is called before the first frame update
    public int dado1, dado2, dado3;
    void Start()
    {
        if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log ("Excelente");
        }
        else if (dado1 == 6 && dado1 == dado2)
        {
            Debug.Log ("Muy bien");
        }
        else if (dado2 == 6 && dado2 == dado3)
        {
            Debug.Log ("Muy bien");
        }
        else if (dado3 == 6 && dado3 == dado1)
        {
            Debug.Log ("Muy bien");
        }
        else if (dado1 == 6 && dado2 != 6 && dado3 != 6)
        {
            Debug.Log ("Regular");
        }
        else if (dado2 == 6 && dado1 != 6 && dado3 != 6)
        {
            Debug.Log ("Regular");
        }
        else if (dado3 == 6 && dado2 != 6 && dado1 != 6)
        {
            Debug.Log ("Regular");
        }
        else 
        {
            Debug.Log ("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
