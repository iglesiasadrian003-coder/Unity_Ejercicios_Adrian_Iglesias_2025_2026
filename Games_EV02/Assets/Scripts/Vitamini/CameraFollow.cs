using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Transform _player;
    //Distancia inical entre la camara y el player
    private Vector3 _offset;
    private Vector3 _smoothDampVelocity;
    //El tiempo que tarda en llegar la camara a donde esta Vitamini
    [SerializeField]
    private float _smoothTargetTime;

    private void Awake() {
        
        //Calcula la distancia inicial entre la camara y Vitamini
        _offset = transform.position - _player.position;

    }

    // Update is called once per frame
    void Update()
    {

        MoveCamera();

    }

    private void MoveCamera() { 
    
        transform.position = Vector3.SmoothDamp(transform.position, 
            _player.position + _offset, ref _smoothDampVelocity, _smoothTargetTime);
    
    }

}
