using UnityEngine;

public class Shop : MonoBehaviour
{

    // Zona de variables globales
    public int NumberBrocoli;
    public int NumberPotatoe;
    // Variables privadas que puede activar el usuario
    [SerializeField]
    private bool _isAddition;
    [SerializeField]
    private bool _isSubtraction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Llamamos al resultado de la operacion
        Operations();


    }

    private void Operations() {

        // Establecemos la condicion de la suma
        if (_isAddition == true) {

            GetAddition(NumberBrocoli, NumberPotatoe);


        }

        // Establecemos la condicion de la resta
        if (_isSubtraction == true) {


            GetSubtraction(NumberBrocoli, NumberPotatoe);


        }

        else {

            Debug.Log(" Establece el tipo de operacion. ");

        
        }

    }


    // Método que siempre suma en orden correcto
    private void GetAddition(int numberBrocoli, int numberPotatoe) {

        // Declaramos la variable de la suma de los valores
        int result = numberBrocoli + numberPotatoe;

        // Imprimimos el resultado
        Debug.Log("La suma total de brócoli y patatas es: " + result + " unidades.");


    }


    // Método que siempre resta en orden correcto (mayor - menor)
    private void GetSubtraction(int numberBrocoli, int numberPotatoe) {

        // Determinamos cuál es el mayor y cuál el menor
        int max = Mathf.Max(numberBrocoli, numberPotatoe);
        int min = Mathf.Min(numberBrocoli, numberPotatoe);

        // Declaramos la variable de la resta del (mayor - menor)
        int result = max - min;

        Debug.Log("La resta total entre brócoli y patatas es: " + result + " unidades.");


    }


}
