﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    //11. Realizá un programa que resuelva el siguiente problema:  
    //Deberá ingresarse por Inspector una fecha de compra
    //(String en el siguiente formato:  YYYYMMDD), un nombre de comprador, 
    //un nombre de producto y una cantidad y precio del producto comprado.
    //Mostrá a modo de ticket, la información ingresada y el monto a pagar.Modelo de Ticket:  
    //Fecha de Compra: YYYYMMDD
    //Nombre del Comprador: xxxxx xxxxx
    //Producto solicitado: xxxxx
    //Cantidad solicitada: xx
    //Precio Unitario: $xxx
    //Total a Pagar: $xxxxx

    public string FechaCompra;
    public string NombreComprador;
    public string NombreProducto;
    public int CantidadProducto;
    public int PrecioProducto;
 void Start()
    {
        Debug.Log("Fecha de Compra: " + FechaCompra + "\n" + "Nombre del Comprador: " + NombreComprador + "\n" + "Producto Solicitado: " + NombreProducto + "\n" + "Cantidad Solicitada: " + CantidadProducto + "\n" + "Precio Unitario: $ " + PrecioProducto + "\n" + "Total a Pagar: $ " + (CantidadProducto * PrecioProducto));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
