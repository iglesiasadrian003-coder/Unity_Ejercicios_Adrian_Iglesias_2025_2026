using UnityEditor.Tilemaps;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VitaminiMovement : MonoBehaviour {

    //Zona de variables globales
    [Header("Velocity")]
    [SerializeField]
    private float _speed;
    //El tiempo que tardara Vitamini en alcanzar la velocidad que queremos
    [SerializeField]
    private float _smoothTime;

    public Rigidbody2D Rb;
    private Animator _anim;
    private SpriteRenderer _spriteRenderer;

    //La velocidad a la que quiero mover el personaje
    private Vector2 _targetVelocity;
    private Vector2 _dampVelocity;

    [Header("Jump")]
    [SerializeField]
    private float _jumpForce;
    private bool _jumpPressed;

    [Header("Raycast")]
    //Punto de origen del "raycast" a los pies de Vitamini
    [SerializeField]
    private Transform _groundCheck;
    //Capa del suelo
    [SerializeField]
    private LayerMask _groundLayer;
    //Longitud del "raycast"
    [SerializeField]
    private float _rayLength;
    //Estamos tocando el suelo?
    public bool IsGrounded;

    [Header("Acorn")]
    [SerializeField]
    private int _numAcorn;
    [SerializeField]
    private TextMeshProUGUI _texAcornUI;

    private void Awake() {

        _texAcornUI.text = "Bellotas perdidas: " + _numAcorn.ToString();
        _jumpPressed = false;
        Rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void FixedUpdate() {

        Move();
        CanJump();
        ChangeGravity();
        RaycastGrounded();

    }

    private void CanJump() {

        if (_jumpPressed == true) { 
        
            Jump();
        
        }
    
    }

    private void RaycastGrounded() {
        
        IsGrounded = Physics2D.Raycast(_groundCheck.position, Vector2.down, _rayLength, _groundLayer);

        Debug.DrawRay(_groundCheck.position, Vector2.down * _rayLength, Color.red);
    
    }

    private void Jump() {

        _jumpPressed = false;
        Rb.AddForce(Vector2.up * _jumpForce);
    
    }

    private void ChangeGravity() {

        if (Rb.linearVelocity.y < 0.0f) {

            Rb.gravityScale = 3.5f;

        }
        else {

            Rb.gravityScale = 1.0f;
        
        }

    }

    // Update is called once per frame
    void Update()
    {

        InputsPlayer();

    }

    private void InputsPlayer() {

        //Teclas que voy a usar (la A y D o < y >)
        float horizontal = Input.GetAxis("Horizontal");   
        _targetVelocity = new Vector2(horizontal * _speed, Rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded == true) { 
        
            _jumpPressed = true;
        
        }

        Flip(horizontal);
        Animating(horizontal);
    
    }

    public void ResetVelocity() { 
    
        //Paro al player reseteando su velocidad
        _targetVelocity = Vector2.zero;
    
    }

    private void Move() {

        Rb.linearVelocity = Vector2.SmoothDamp(Rb.linearVelocity, _targetVelocity, ref _dampVelocity, _smoothTime);

    }

    private void Animating(float h) {

        if (h != 0.0f) { 
        
            _anim.SetBool("IsRunning", true);
        
        }
        else {

            _anim.SetBool("IsRunning", false);

        }

        _anim.SetBool("IsJumping", !IsGrounded);
    
    }

    private void Flip(float h) {

        if(h > 0.0f) {

            _spriteRenderer.flipX = false;

        }
        else if(h < 0.0f) { 
        
            _spriteRenderer.flipX = true;
        
        }
    
    }

    private void OnCollisionEnter2D(Collision2D infocollision) {

        if (infocollision.collider.CompareTag("Acorn")) {

            Destroy(infocollision.collider.gameObject);
            _numAcorn--;
            _texAcornUI.text = "Bellotas perdidas: " + _numAcorn.ToString();

            if (_numAcorn == 0) {

                GetNewScene();
            
            }
        
        }
        
    }

    private void GetNewScene() {

        SceneManager.LoadScene(0);
    
    }

}
