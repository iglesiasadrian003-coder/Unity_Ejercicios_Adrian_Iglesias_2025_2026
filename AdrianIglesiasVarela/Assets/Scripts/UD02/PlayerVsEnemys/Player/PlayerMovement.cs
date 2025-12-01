using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Zona de variables globales
    //Establecemos las variables serializadas del la velocidad y del giro
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    //Establecemos las variables del movimiento
    private float _horizontal;
    private float _vertical;

    //Establecemos las variables del componente de animacion y del "ray" y "raymask"
    private Animator _anim;
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLenght;
    [SerializeField]
    private LayerMask _raymask;

    //Establecemos la variable del "RigidBody"
    private Rigidbody _rb;
    //Establecemos las variables del salto
    [SerializeField]
    private float _forceJump;
    private bool _isGrounded;
    private bool _canJump;

    private void Awake() {

        //Mi variable "_anim" apunta al componente Animator
        //del "gameObject" que lleva este "script"
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();

    }

    private void FixedUpdate() {

        LaunchRaycast();
        if (_canJump == true) {

            _canJump = false;
            Jump();

        }

    }


    // Update is called once per frame
    void Update()
    {
        //Llamamos a los metodos
        InputsPlayer();
        Move();
        Turn();
        Animating();
        CanJump();

    }

    private void Jump() {

        _rb.AddForce(Vector3.up * _forceJump);

    }

    private void LaunchRaycast() {


        _ray.origin = transform.position;
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, _rayLenght, _raymask)) {

            Debug.Log("Estoy tocando el suelo");
            _isGrounded = true;

        }

        else {

            _isGrounded = false;

        }

        Debug.DrawRay(_ray.origin, _ray.direction * _rayLenght, Color.red);

    }

    private void CanJump() {

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded == true) {

            _canJump = true;

        }

    }

    private void InputsPlayer() {

        //Establecemos los inputs "horizontal" y "vertical" del "player"
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    
    }

    private void Move() {

        //Establecemoos el movimiento "transform" y la velocidad de esta del "player"
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);
    
    }

    private void Turn() {

        //Establecemoos la rotacion "transform" y la velocidad de esta del "player"
        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);

    }

    private void Animating() {

        if (_vertical > 0) { //El personaje se esta moviendo hacia delante

            //La animacion hacia delante se ejecuta
            _anim.SetBool("IsMovingForward", true);

        }

        else {//"_vertical" es igual a 0.0f y , por tanto, el personaje esta parado

            //La animacion hacia delante no se ejecuta
            _anim.SetBool("IsMovingForward", false);

        }


        if (_vertical < 0) { //El personaje se esta moviendo hacia atras

            //La animacion hacia atras se ejecuta
            _anim.SetBool("IsMovingBackward", true);

        }

        else {//"_vertical" es igual a 0.0f y , por tanto, el personaje esta parado

            //La animacion hacia atras no se ejecuta
            _anim.SetBool("IsMovingBackward", false);

        }
        

    }


}
