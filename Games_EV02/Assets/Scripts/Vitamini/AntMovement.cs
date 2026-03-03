using UnityEngine;
using UnityEngine.UIElements;

public class AntMovement : MonoBehaviour {

    //Zona de variables globales
    //Los puntos por donde quiero que patrulle la hormiga
    [SerializeField]
    private Transform[] _wayPointsArray;
    //Posiciones de la patrulla, es decir,
    //cojo la position de la Transform anterior
    [SerializeField]
    private Vector2[] _positionsArray;
    private Vector3 _posToGo;
    private int _index;
    private SpriteRenderer _spriteRenderer;
    private Animator _anim;
    [SerializeField]
    private GameObject _player;

    //Velocidad de la hormiga 
    private float _speed;
    //Velocidad normal de la hormiga
    [SerializeField]
    private float _speedWalking;
    [SerializeField]
    private float _speedAttack;
    [SerializeField]
    private float _speedAnimation;
    [SerializeField]
    private float _distanceToPlayer;


    private void Awake() {

        _speed = _speedWalking;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();

        //Inicializamos el array de posiciones con el tamaño
        //que tiene el de los waypoints
        _positionsArray = new Vector2[_wayPointsArray.Length];
        for (int i = 0; i < _wayPointsArray.Length; i++) {

            _positionsArray[i] = _wayPointsArray[i].position;
        
        }
        //Cogemos el contenido de _positionsArray en el cajon 0 y lo asigno
        //al _posToGo
        _posToGo = _positionsArray[0];

    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawLine(transform.position, _player.transform.position, Color.red);
        if (Vector2.Distance(transform.position, _player.transform.position) <= _distanceToPlayer) {

            AttackPlayer();

        }
        else { 
        
            ChangeTargetPos();

        }

        Flip();

        //El MoveTowards cambia el valor de un vector desde el valor que se encuentra hasta el 
        //valor y velocidad que queramos
        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);

    }

    private void ChangeTargetPos() {

        _speed = _speedWalking;
        _anim.speed = 1.0f;

        //Si hemos llegado a nuestro destino
        if (transform.position == _posToGo) {

            //Vuelvo al punto inicial si he llegado al ultimo cajon del Array
            if (_index == _positionsArray.Length - 1) {

                _index = 0;

            }
            //Si no he llegado al ultimo cajon, continuo el recorrido hasta el siguiente cajon
            else { 
            
                _index++;
            
            }

            //Ahora estamos en el cajon 1, que es lo mismo que el elemento 0 del Array
             _posToGo = _positionsArray[_index];
        
        }

    
    }

    private void Flip() {

        if (_posToGo.x > transform.position.x) {

            //Caminar hacia la derecha
            _spriteRenderer.flipX = true;

        }
        else if(_posToGo.x < transform.position.x) { 
        
            //Caminar hacia la izquierda
            _spriteRenderer.flipX = false;
        
        }
    }

    public void AttackPlayer() {

        _speed = _speedAttack;
        //Si ve al player, aumenta su velocidad el clip de animacion
        _anim.speed = _speedAnimation;
        _posToGo = new Vector2(_player.transform.position.x, _posToGo.y);
    
    }

    private void OnCollisionEnter2D(Collision2D infoCollision) {

        if (infoCollision.collider.CompareTag("Player") && 
            infoCollision.collider.GetComponent<VitaminiMovement>().IsGrounded) {

            infoCollision.collider.GetComponent<VitaminiHealth>().TakeDamage(20.0f);
        
        }
    
    }

}
