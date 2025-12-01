using UnityEngine;

public class DollarsToEuros : MonoBehaviour
{

    //variables globales
    private float _euro;
    public float Dollar;   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _euro = 0.90f;
        Debug.Log(GetDollarToEuro());


    }

    private float GetDollarToEuro()
    {

        //variable locales
        float conversion = 0.0f;

        //calcular la conversion de dolares a euros
        conversion = Dollar * _euro;

        //devolver el valor de tipo "float"
        return conversion;


    }

}
