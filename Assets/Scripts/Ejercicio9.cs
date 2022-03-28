using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    //9. Realizá un programa que resuelva el siguiente problema:
    //Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
    //total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
    //por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
    //mostrar lo pedido en el siguiente formato:
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
     public string persona1, persona2, persona3;
     public float ingre1, ingre2, ingre3;
   
    void Start()
    {
        Debug.Log ("Nombre:" + persona1 + ",Capital aportado: $" + ingre1 + ", Porcentaje del capital: %"+ ingre1 / (ingre1 * ingre2 * ingre3) * 100 +", Monto total aportado: $"+ (ingre1 + ingre2 + ingre3));
        Debug.Log ("Nombre:" + persona2 + ",Capital aportado: $" + ingre2 + ", Porcentaje del capital: %"+ ingre2 / (ingre1 * ingre2 * ingre3) * 100 +", Monto total aportado: $"+ (ingre1 + ingre2 + ingre3));
        Debug.Log ("Nombre:" + persona3 + ",Capital aportado: $" + ingre3 + ", Porcentaje del capital: %"+ ingre3 / (ingre1 * ingre2 * ingre3) * 100 +", Monto total aportado: $"+ (ingre1 + ingre2 + ingre3));
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
