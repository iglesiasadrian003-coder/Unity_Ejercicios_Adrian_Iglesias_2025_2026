using UnityEngine;

public class MovementAxis : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private float _speed = 0.8f;
    [SerializeField]
    private float _turnSpeed = 45.0f;
    [SerializeField]
    private float _vertical;
    [SerializeField]
    private float _horizontal;


    // Update is called once per frame
    void Update()
    {

        InputCube();

    }

    private void InputCube() { 
    
        
        //Teclas A y D y las flechas para la < y la >
        _horizontal = Input.GetAxis("Horizontal");
        //Teclas W y S y las flechas para up y down
        _vertical = Input.GetAxis("Vertical");

        //Aplicamos el valor del eje vertical al "translate"
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
        //Aplicamos el valor del eje horizontal al "rotate"
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

}
