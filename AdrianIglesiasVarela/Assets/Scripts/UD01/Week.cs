using UnityEngine;

public class Week : MonoBehaviour
{

    // Zona de variables globales
    public int DayNumber;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Llamamos a la variable "IsDayWeek"
        IsDayWeek();

    }


    // Método privado que determina qué día de la semana corresponde a un número
    private void IsDayWeek() {


        switch (DayNumber) {

            // Se imprimen los dias de semana segun el numero introducido
            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Miercoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("Sabado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
            default:
                // Si el número no está entre 1 y 7, se muestra un mensaje de error
                Debug.Log(" El numero introducido no se corresponde con ningun dia de la semana ");
                break;


        }


    }


}
