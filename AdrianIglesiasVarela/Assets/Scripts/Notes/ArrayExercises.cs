using UnityEngine;

public class ArrayExercises : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        GetPositiveNumbers();
        GetNegativeNumbers();

    }

    private void GetPositiveNumbers() 
    {

        int[] numbersArray = { 24, -56, 8, 12, -54, 34, -26, -87, 93, 0 };
        //int[] numbersArray = new int[10] { 24, 56, 8, 12, 54, 34, 26, 87, 93, 0};

        for (int i = 0; i < numbersArray.Length; i++) 
        {

            if (numbersArray[i] >= 0) 
            {

                Debug.Log(numbersArray[i]);          
            
            }


        }


    }

    private void GetNegativeNumbers() 
    {

        int[] numbersArray = { 24, -56, 8, 12, -54, 34, -26, -87, 93, 0 };

        for (int i = 0; i < numbersArray.Length; i++) 
        {

            if (numbersArray[i] < 0) 
            {

                Debug.Log(numbersArray[i]);

            }


        }


    }

}
