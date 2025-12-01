using UnityEngine;

public class MovementRabbit : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    private float _horizontal;
    private float _vertical;

    private Animator _anim;
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLenght;
    [SerializeField]
    private LayerMask _raymask;

    private Rigidbody _rb;
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
    void Update() {

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

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");


    }

    private void Move() {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }

    private void Turn() {

        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);

    }

    private void Animating() {

        if (_vertical != 0) { //El personaje se esta moviendo

            _anim.SetBool("IsMoving", true);

        }

        else {//"_vertical" es igual a 0.0f y , por tanto, el personaje esta parado

            _anim.SetBool("IsMoving", false);

        }

    }
}
