using UnityEngine;

public class Logic : MonoBehaviour {





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {


        GetLogicArray();


    }

    private void GetLogicArray() {

        // Definimos un array de 3 valores logicos (bool)
        bool[] logicArray = new bool[3];


        // Definimos el valor de falso para todas las posiciones del array
        for (int i = 0; i < logicArray.Length; i++) {

            logicArray[i] = false;


        }

        // Marcamos la primera posicion del indice como verdadera
        logicArray[0] = true;

        for (int i = 0; i < logicArray.Length; i++) {

            // Imprimimos en consola todos los valores en cada posicion
            Debug.Log(" Posicion " + i + ": " + logicArray[i]);


        }


    }


}
