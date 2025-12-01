using UnityEngine;

public class IncreasingOrder : MonoBehaviour {

    // Zona de variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {

        // Llamamos al metodo
        CheckIncreasingOrder(); 

    }

    // Creamos un metodo privado que compruebe el orden creciente
    private void CheckIncreasingOrder() {

        // Comprobamos si los tres numeros son iguales
        if (NumberOne == NumberTwo && NumberTwo == NumberThree) {

            Debug.Log(" Los tres numeros son iguales. ");

        }

        // Comprobamos si el orden es creciente
        // Para ser creciente: primero < segundo < tercero
        else if (NumberOne < NumberTwo && NumberTwo < NumberThree) {

            Debug.Log(" El orden es creciente: " + NumberOne + "," + NumberTwo + "," + NumberThree);

        }

        // Si no cumplen el orden creciente
        else {

            Debug.Log("El orden no es creciente. ");
        
        }


    }


}
