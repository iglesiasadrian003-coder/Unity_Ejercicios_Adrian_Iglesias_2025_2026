using System.Collections.Generic;
using UnityEngine;

public class ListExercises : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        GetPositiveNumbers();
        GetNegativeNumbers();

    }


    private void GetPositiveNumbers() 
    {

        List<int> numbersList = new List<int>() {-3, 8, 89, 40, -52, 0, -2, -36, 88, -19};

        foreach (int item in numbersList) 
        {

            if (item >= 0) 
            {

                Debug.Log(item);

            }
        }
    
    }

    private void GetNegativeNumbers() {

        List<int> numbersList = new List<int>() { -3, 8, 89, 40, -52, 0, -2, -36, 88, -19 };

        foreach (int item in numbersList) {

            if (item < 0) {

                Debug.Log(item);

            }
        }

    }

}
