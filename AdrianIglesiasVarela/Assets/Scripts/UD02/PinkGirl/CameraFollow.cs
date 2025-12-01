using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //Zona de varibles globales 
    [SerializeField]
    private Transform _target;

    [Header("Vectors")]
    //Velocidad de seguimiento de la camara
    [SerializeField]
    private float _smoothing;
    //Distancia inicial que hay entre la camara y el "player"
    [SerializeField]
    private Vector3 _offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        _offset = transform. position - _target.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        //Posicion a la que queremos mover la camara
        Vector3 desiredPosition = _target.position + _offset;

        //Mover la camara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);

    }
}
