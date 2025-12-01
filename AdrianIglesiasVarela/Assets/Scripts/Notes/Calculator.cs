using UnityEngine;

public class Calculator : MonoBehaviour {

    //variables globales 
    //Los numeros decimales que puede introducir el usuario
    [SerializeField]
    private float _numberOne;
    [SerializeField]
    private float _numberTwo;
    //Los booleanos que puede activar el usuario
    [SerializeField]
    private bool _isAddition;
    [SerializeField]
    private bool _isSubtraction;
    [SerializeField]
    private bool _isMultiplication;
    [SerializeField]
    private bool _isDivision;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {

        Operations();

    }

    // Update is called once per frame
    private void Operations() 
    {

        if (_isAddition == true) 
        {

            GetAddition(_numberOne, _numberTwo);

        }

        if (_isSubtraction == true) 
        {

            GetSubtraccion(_numberOne, _numberTwo);

        }

        if (_isMultiplication == true) {

            GetMultiplication(_numberOne, _numberTwo);

        }

        if (_isDivision == true) 
        {

            GetDivision(_numberOne, _numberTwo);

        }


    }
    private void GetAddition(float numberOne, float numberTwo) 
    {

        float result = numberOne + numberTwo;

        Debug.Log("La suma del numero uno y numero dos es: " + result);

        
    }

    private void GetSubtraccion(float numberOne, float numberTwo) 
    {

        float result = numberOne - numberTwo;

        Debug.Log("La resta del numero uno y numero dos es: " + result);


    }
    private void GetMultiplication(float numberOne, float numberTwo) 
    {

        float result = numberOne * numberTwo;

        Debug.Log("La multiplicacion del numero uno y numero dos es: " + result);


    }

    private void GetDivision(float numberOne, float numberTwo) 
    {

        float result = numberOne / numberTwo;

        Debug.Log("La multiplicacion del numero uno y numero dos es: " + result);


    }

}
