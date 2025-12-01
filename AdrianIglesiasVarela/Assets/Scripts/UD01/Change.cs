using UnityEngine;

public class Change : MonoBehaviour
{




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
        GetArrayChange();


    }

    private void GetArrayChange() {
        
        //Definimos un array de 5 valores inicializados en 1
        int[] numbers = { 1, 1, 1, 1, 1 };

        Debug.Log(" El array tiene " + numbers.Length + " elementos.");

        // Cambiamos el valor de la primera y ultima poscion a 42

        // Primera posicion
        numbers[0] = 42;

        // Ultima posicion
        numbers[numbers.Length  - 1] = 42;

        for (int i = 0; i < numbers.Length; i++) {

            // Imprimimos en consola el valor de cada posicion del array
            Debug.Log(" Posicion " + i + ":" + numbers[i]);

        
        }


    }


}
