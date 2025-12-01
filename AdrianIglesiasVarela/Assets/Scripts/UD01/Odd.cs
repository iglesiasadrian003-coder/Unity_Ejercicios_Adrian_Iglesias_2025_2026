using UnityEngine;

public class Odd : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetOddNumbers0To100();

    }

    // Creamos un metodo privado que nos imprima los numeros impares entre el 0 y 100
    private void GetOddNumbers0To100() {

        Debug.Log(" Los numeros impares entre el 0 y el 100 son: ");

        // Recorremos con un bucle los numeros del 1 al 100
        for (int i = 0; i <= 100; i++) {

            // Comprobamos los numeros impares
            // Un numero es impar si al dividir entre 2, es distinto de 0
            if (i % 2 != 0) {

                Debug.Log(i);
            
            }
        
        }
    
    }

        
}
