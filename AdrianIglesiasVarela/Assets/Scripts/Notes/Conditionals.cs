using UnityEngine;

public class Conditionals : MonoBehaviour
{
    
    //variables globales
    public int NumberOne;
    public int NumberTwo;
    public char Letter;
    public int DayNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsPositive();
        IsOdd();
        IsAscendingNumber();
        IsVowel();
        IsDayWeek();

    }


    private void IsPositive() 
    {

        if(NumberOne >= 0)
        {

            Debug.Log(NumberOne +  " es positivo.");

        }
        else 
        {

            Debug.Log(NumberOne + " es negativo.");

        }
        


    }

    private void IsOdd()
    {
        
        if(NumberOne % 2 == 0)
        {

            Debug.Log(NumberOne + " es par.");

        }
        else 
        {

            Debug.Log(NumberOne + " es impar.");

        }

    }

    private void IsAscendingNumber() {

        if (NumberOne < NumberTwo) 
        {

            Debug.Log("El orden ascendente es: " + NumberOne + "\t" + NumberTwo);

        }
        else if (NumberOne == NumberTwo) 
        {
            
            Debug.Log(" Los numeros son iguales. ");

        }
        else 
        {

            Debug.Log(" El orden ascendente es: " + NumberTwo + "\t" + NumberOne);

        }

    }


    private void IsVowel() 
    {

        if (Letter == 'a' || Letter == 'e' || Letter == 'i' || Letter == 'o' || Letter == 'u' ||
            Letter == 'A' || Letter == 'E' || Letter == 'I' || Letter == 'O' || Letter == 'U') {

            Debug.Log(Letter + " es una vocal.");

        }
        else {

            Debug.Log(Letter + " no es una vocal.");

        }

    }

    private void IsDayWeek()
    {

       switch (DayNumber) 
       {

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
                Debug.Log(" El numero introducido no se corresponde con ningun dia de la semana ");
                break;

       } 


    }

}
