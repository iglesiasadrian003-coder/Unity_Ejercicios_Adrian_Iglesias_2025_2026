using UnityEngine;

public class Score : MonoBehaviour {

    // Zona de variables globales
    public int NumberOne;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {

        GetScore(NumberOne);

    }


    private void GetScore(int number) {

        // Si el numero es igual a 45
        if (number == 45) {

            Debug.Log(" Se ha llegado a la maxima puntuacion: " + NumberOne);


        }

        // Si el numero es distinto de 45
        else if (number < 45) {

            // Declaramos el resultado de la resta con el numero introducido y la puntuacion maxima
            int result = 45 - number;

            // Imprimimos por consola cuanto queda hasta el 45
             Debug.Log(" Quedan: " + result + " puntos ,hasta 45 ");
        }


        

        else {

            Debug.Log(" El numero introducido supera la puntuacion maxima. ");
        
        
        }


    }


}
