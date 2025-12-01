using UnityEngine;

public class Movement : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    /*[SerializeField]
    private Space _mySpace;
    [SerializeField]
    private KeyCode _myKeyCode;
    [SerializeField]
    private ForceMode _myForceMode;*/


    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.W)) {


            transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S)) {


            transform.Translate(Vector3.back * _speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A)) {


            transform.Rotate(-Vector3.up * _turnSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D)) {


            transform.Rotate(Vector3.up * _turnSpeed * Time.deltaTime);

        }


    }
}
