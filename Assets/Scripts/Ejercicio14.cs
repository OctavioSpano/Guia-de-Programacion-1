using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    // Start is called before the first frame update
    public string letraOperacion;
    public int num1, num2;
    void Start()
    {
        switch (letraOperacion)
        {
            case "s":
            Debug.Log(num1 + num2);
            break;
            case "r":
            Debug.Log(num1 - num2);
            break;
            case "p":
            Debug.Log(num1 * num2);
            break;
            case "d":
            Debug.Log(num1 / num2);
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
