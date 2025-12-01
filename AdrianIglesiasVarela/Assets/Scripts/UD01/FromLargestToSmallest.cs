using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{

    //Zona de variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsAscendingNumber();

    }

    // Método privado que ordena tres números usando condicionales
    private void IsAscendingNumber() {

        // Primero comprobamos si los tres números son iguales
        if (NumberOne == NumberTwo && NumberTwo == NumberThree) {

            Debug.Log(" Los numeros son iguales. ");

        }

        // Si dos números son iguales pero el tercero es diferente
        else if (NumberOne == NumberTwo && NumberTwo != NumberThree) {

            if (NumberThree < NumberOne) {

                Debug.Log(" El orden de mayor a menor es: " + NumberOne + "\t" + NumberTwo + "\t" + NumberThree);

            }
            else {

                Debug.Log(" El orden de mayor a menor es: " + NumberThree + "\t" + NumberOne + "\t" + NumberTwo);

            }

        }

        else if (NumberOne == NumberThree && NumberOne != NumberTwo) {

            if (NumberTwo < NumberOne) {

                Debug.Log(" El orden de mayor a menor es: " + NumberOne + "\t" + NumberThree + "\t" + NumberTwo);


            }
            else {

                Debug.Log(" El orden de mayor a menor es: " + NumberTwo + "\t" + NumberOne + "\t" + NumberThree);

            }

        }

        else if (NumberTwo == NumberThree && NumberTwo != NumberOne) {

            if (NumberOne < NumberTwo) {

                Debug.Log(" El orden de mayor a menor es: " + NumberTwo + "\t" + NumberThree + "\t" + NumberOne);


            }
            else {

                Debug.Log(" El orden de mayor a menor es: " + NumberOne + "\t" + NumberTwo + "\t" + NumberThree);

            }

        }


        // Si todos los numeros son diferentes 
        else {

            // Caso 1: NumberOne es el menor
            if (NumberOne > NumberTwo && NumberOne > NumberThree) {

                if (NumberTwo > NumberThree) {

                    Debug.Log(" El orden de mayor a menor es: " + NumberOne + "\t" + NumberTwo + "\t" + NumberThree);

                }
                else {

                    Debug.Log(" El orden de mayor a menor es: " + NumberOne + "\t" + NumberThree + "\t" + NumberTwo);

                }

            }

            // Caso 2: NumberTwo es el menor
            else if (NumberTwo > NumberOne && NumberTwo > NumberThree) {

                if (NumberOne > NumberThree) {

                    Debug.Log(" El orden de mayor a menor es: " + NumberTwo + "\t" + NumberOne + "\t" + NumberThree);

                }
                else {

                    Debug.Log(" El orden de mayor a menor es: " + NumberTwo + "\t" + NumberThree + "\t" + NumberOne);

                }

            }

            // Caso 3: NumberThree es el menor
            else {

                if (NumberOne > NumberTwo) {

                    Debug.Log(" El orden de mayor a menor es: " + NumberThree + "\t" + NumberOne + "\t" + NumberTwo);

                }
                else {

                    Debug.Log(" El orden de mayor a menor es: " + NumberThree + "\t" + NumberTwo + "\t" + NumberOne);

                }

            }

        }


    }

    /*private void IsAscendingNumber() {
       
        // Comprobamos si los tres números son iguales
        if (NumberOne == NumberTwo && NumberTwo == NumberThree) {

            Debug.Log("Los tres números son iguales.");

        }
        else {

            // Creamos un array con los tres números
            int[] numbers = { NumberOne, NumberTwo, NumberThree }; // int[] numbers = new int[3] { NumberOne, NumberTwo, NumberThree};

            // Ordenamos el array de Menor a Mayor
            System.Array.Sort(numbers);

            // Invertimos el array para que quede de Mayor a Menor
            System.Array.Reverse(numbers);

            // Mostramos el resultado en la consola
            Debug.Log("El orden de mayor a menor es: " + numbers[0] + "\t" + numbers[1] + "\t" + numbers[2]);

        }

    }*/

}
