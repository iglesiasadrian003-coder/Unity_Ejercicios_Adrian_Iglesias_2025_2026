using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    // Zona de variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        CheckDecreasingOrder();

    }

    // Creamos un metodo privado que compruebe el orden decreciente
    private void CheckDecreasingOrder() {

        // Comprobamos si los tres numeros son iguales
        if (NumberOne == NumberTwo && NumberTwo == NumberThree) {

            Debug.Log(" Los tres numeros son iguales. ");

        }

        // Comprobamos si el orden es decreciente
        // Para ser decreciente: primero > segundo > tercero
        else if (NumberOne > NumberTwo && NumberTwo > NumberThree) {

            Debug.Log(" El orden es decreciente: " + NumberOne + "," + NumberTwo + "," + NumberThree);

        }

        // Si no cumplen el orden decreciente
        else {

            Debug.Log("El orden no es decreciente. ");

        }


    }


}
