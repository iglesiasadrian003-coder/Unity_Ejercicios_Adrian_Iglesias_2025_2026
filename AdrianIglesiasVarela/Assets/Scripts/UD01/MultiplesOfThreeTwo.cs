using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetMultiplesOf2And3();

    }

    // Creamos un metodo privado que nos imprima los multiplos de 3 entre el 0 y 100
    private void GetMultiplesOf2And3() {

        Debug.Log(" Los multiplos de 2 y 3 entre el 0 y el 100 son: ");

        // Recorremos con un bucle los numeros del 1 al 100
        for (int i = 0; i <= 100; i++) {

            // Comprobamos los multiplos de 2 y 3
            // Un numero es multiplo de 2 y de 3 si su resto al dividir entre 2 y de 3 es igual a 0
            if (i % 2 == 0 && i % 3 == 0) {

                Debug.Log(i);

            }

        }

    }


}
