using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        GetPredictions();


    }


    private void GetPredictions() {


        // Definimos un array de 5 cadenas de texto con predicciones
        string[] predictions = new string[5] {


            "Vas a lograr algo que llevas mucho tiempo deseando.",
            "Una sorpresa inesperada cambiará tu semana.",
            "Tu creatividad te abrirá una nueva oportunidad laboral.",
            "Hoy encontrarás motivación en un lugar que no esperabas.",
            "Tu esfuerzo será reconocido muy pronto."


        };

        // Generamos un numero aletario entre 0 y 4
        int randomIndex = Random.Range(0, predictions.Length);

        // Imprimimos por consola la prediccion
        Debug.Log(" Tu prediccion de hoy es: " + predictions[randomIndex]);

    
    }


}
