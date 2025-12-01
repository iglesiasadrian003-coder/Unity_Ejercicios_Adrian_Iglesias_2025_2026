using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    //Zona de variables globales
    public int IntegerNumber = -35;
    public float StudentGrade = 8.5f; //8.0f
    public string StudentName = "Juan";
    public bool IsAnActiveStudent = true;
    public char Password = '*';
    public long BigNumber = 123412341234;
    public double BigStudentGrade = 8.55555d;
    public byte LittleNumber = 255;
    public byte ExampleAdd = 134;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StudentGrade = 5 + (8 - ((9 * 8) / 7));
        LittleNumber = 2 % 1; // LittleNumber = 0;
        LittleNumber = 3 % 2; // LittleNumber = 1;

        // Imprimir en consola -- concatenacion
        // Debug.Log("El resultado de la operación de  módulo es: " + LittleNumber);
        Debug.Log(LittleNumber + "1234");
        Debug.Log("El número más \"pequeño\" del mundo es: \n " + LittleNumber);

    }

    // Update is called once per frame
    void Update()
    {

        //StudentGrade = StudentGrade + 1;//StudentGrade ++; //StudentGrade += 1;
        StudentGrade --;

        LittleNumber = 254;
        Debug.Log(LittleNumber);

    }
}
