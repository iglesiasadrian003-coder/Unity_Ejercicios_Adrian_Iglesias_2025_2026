using UnityEngine;

public class Substraction : MonoBehaviour
{


    //Zona de variables globales
    public int NumberOne;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        CalculateSubstraction();

    }

    private void CalculateSubstraction() {

        // Inicializamos la primera varibale con el valor 1
        int result = 1;


        // Comprobamos si el numero es mayor o igual a 1
        if (NumberOne < 1) {

            Debug.Log(" Introduce un numero mayor que 1. ");
            return; // Sale del metodo


        }

        // Recorremos el bucle desde el 2 hasta el numero introducido
        for (int i = 2; i <= NumberOne; i++) {

            // En cada iteraccion restamos el numero actual al resultado
            result -= i;
        
        
        }

        Debug.Log(" La resta de los numeros del 1 al " + NumberOne + " es: " + result);

    }
    

}
