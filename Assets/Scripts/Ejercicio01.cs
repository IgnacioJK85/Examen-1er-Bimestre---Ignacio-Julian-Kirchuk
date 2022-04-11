//Vamos a programar un algoritmo que permita al usuario convertir una cantidad de dinero en pesos argentinos a su equivalente en moneda extranjera.Se debe poder ingresar por Inspector el monto a convertir y una letra correspondiente a la moneda extranjera que se quiere convertir, las opciones son:

//D, para dólares
//R, para reales
//E, para euros

//(La cotización de la moneda será investigada por quien realice el examen).

//El programa debe cumplir los siguientes requerimientos:
//Si se ingresa otra cosa que no sea “D”, “R” o “E” se debe mostrar el mensaje “Opción de moneda extranjera no válida”.

//Si la cantidad de dinero de dinero a convertir es menor que 1000, mostrar el mensaje “El monto mínimo es $1000”. 

//Si los valores ingresados son válidos devolver el mensaje 
//"[monto a convertir] pesos argentinos equivalen a [cantidad covertida] [moneda elegida] ". Ejemplo: "1000 pesos equivalen a 3 dólares".

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public char moneda;
    public int monto;
    // Start is called before the first frame update
    void Start()
    {
        if (monto >= 1000)
        {
            switch (moneda)
            {
                case 'D':
                    float convertidodolares = monto / 100;
                    Debug.Log("" + monto + " pesos argentinos equivalen a " + convertidodolares + " dólares");
                    break;
                case 'R':
                    float convertidoreales = monto / 20;
                    Debug.Log("" + monto + " pesos argentinos equivalen a " + convertidoreales + " reales");
                    break;
                case 'E':
                    float convertidoeuros = monto / 120;
                    Debug.Log("" + monto + " pesos argentinos equivalen a " + convertidoeuros + " euros");
                    break;
                default:
                    Debug.Log("Opción de moneda extranjera no válida");
                    break;
            }
        }
        else
        {
            Debug.Log("El monto mínimo es $1000");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
