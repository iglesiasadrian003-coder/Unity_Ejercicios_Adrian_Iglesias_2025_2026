using UnityEngine;

public class Clicker : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private float _thrust;
    private Rigidbody _rb;


    private void Awake() {

        _rb = GetComponent<Rigidbody>();
        _rb.useGravity = true;

    }

    private void OnMouseDown() {
        
        _rb.AddForce(transform.up * _thrust);

    }

}
