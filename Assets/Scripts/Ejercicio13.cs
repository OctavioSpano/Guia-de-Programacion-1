using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    // Start is called before the first frame update
    public int horasTrabajadas;
    void Start()
    {
        int pagoPrimerasHoras = 16;
        int pagoHorasExtra = 20;
        int primerasHoras = 40;
        int horasExtra = horasTrabajadas - 40;
        if (horasTrabajadas <= 40)
        {
            Debug.Log ("Se le pagarán $" + horasTrabajadas * pagoPrimerasHoras);
        }
        else if (horasTrabajadas > 40)
        {
            Debug.Log ("Se le pagarán $" + (primerasHoras * pagoPrimerasHoras + horasExtra * pagoHorasExtra));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
