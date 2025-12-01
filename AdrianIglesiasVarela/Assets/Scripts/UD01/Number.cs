using UnityEngine;

public class Number : MonoBehaviour {


    // Zona de variables globales
    public int NumberOne;

    
    void Start() {


        // Llamamos al método privado, pasando el número como parámetro
        int newNumber = GetIncrement(NumberOne);

        // Si el número introducido es distinto de 0, mostramos el resultado
        if (NumberOne != 0) {


            Debug.Log(" El número incrementado es: " + newNumber);


        }


    }

    // Método que recibe un número por parámetro y devuelve su valor incrementado en 1
    private int GetIncrement(int number) {


        // Verificamos si el número es 0
        if (number == 0) {


            // Mostramos mensaje en consola y devolvemos el mismo valor
            Debug.Log("Introduce otro número, por favor:");
            return number; // No se incrementa


        }

        // Si el número no es 0, lo incrementamos en 1
        number = number + 1;

        // Devolvemos el nuevo valor
        return number;


    }


}
