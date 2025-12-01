using UnityEngine;

public class Rectangle : MonoBehaviour
{

    //variables globales
    private float _width,
                  _height;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _width = 12.5f;
        _height = 6.1f;

        GetArea();
        GetPerimeter();
        GetDiagonal();

    }

    private void GetArea()
    {
        //variables locales
        float area = 0.0f;

        //calcular el área
        area = _width * _height;

        //mostrar el área por consola
        Debug.Log("El área del rectángulo es: " + area);

    }


    private void GetPerimeter()
    {

        //variables locales
        float perimeter = 0.0f;

        //calcular el perímetro
        perimeter = 2 * (_width + _height);

        //mostrar el perímetro por consola
        Debug.Log("El perímetro del rectángulo es: " + perimeter);


    }

    private void GetDiagonal()
    {

        //variables locales
        float diagonal = 0.0f;

        //calcular la longitud de la diagonal
        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));

        //mostrar la diagonal por consola
        Debug.Log("La diagonal del rectángulo es: " + diagonal);

    }

}
