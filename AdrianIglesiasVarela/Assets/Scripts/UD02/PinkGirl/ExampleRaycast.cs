using UnityEngine;

public class ExampleRaycast : MonoBehaviour {

    //Zona de varibles globales
    //Variable donde vamos a guardar la inforamcion del rayo
    private Ray _ray;
    //Guardar la informacion del choque entrel el "raycast" y el "collider" del "gameObject"
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLength;
    [SerializeField]
    private LayerMask _enemyMask;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        _ray.origin = transform.position;
        //Hacia delante, hacia donde esta mirando la "PinkGirl"
        _ray.direction = transform.forward;

        if (Physics.Raycast(_ray, out _hit, _rayLength, _enemyMask)) {

            Debug.Log("Estoy chocando con algo" + _hit.collider.name);
            Debug.Log("Punto del impacto: " + _hit.point);
            Debug.Log("Distancia: " + _hit.distance);

            _hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * 500.0f);

        }

        Debug.DrawRay(_ray.origin, _ray.direction * _rayLength, Color.red);

    }
}
