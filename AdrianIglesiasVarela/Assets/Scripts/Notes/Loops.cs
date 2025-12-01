using UnityEngine;

public class Loops : MonoBehaviour
{
    //variables globales
    public int Number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetNumbers0To100While();
        GetNumbers100To0For();
        GetNumbers1ToNumberWhile();
        
    }

    private void GetNumbers0To100While() 
    {
    

        //crear e inicializar la variable de incremento
        int i = 0;

        //crear el  while
        while(i < 101) 
        { 
        
            Debug.Log(i);
            i++; //i + 1;
        
        }

    }

    private void GetNumbers100To0For() 
    {

        for(int i = 100; i > -1; i--) 
        {

            Debug.Log(i);

        }


    }

    private void GetNumbers1ToNumberWhile() 
    {

        for(int i = 1; i <= Number; i++) 
        {

            Debug.Log(i);
        
        }
    
    }
    
}
