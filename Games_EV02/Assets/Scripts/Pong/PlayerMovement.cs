using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Zona de variables globales 
    [SerializeField]
    private float _speed;
    [SerializeField]
    private int _playerIndex;

    private Rigidbody2D _rb;


    private void Awake() {
        
        _rb = GetComponent<Rigidbody2D>();

    }

    
    // Update is called once per frame
    void Update()
    {

        InputsPlayer();

    }

    private void InputsPlayer() {

        float vertical = Input.GetAxis("Vertical" + _playerIndex);
        _rb.linearVelocity = new Vector2(0.0f, vertical * _speed);
    
    }

}
