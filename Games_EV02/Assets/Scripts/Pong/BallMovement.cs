using UnityEngine;

public class BallMovement : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private float _minXspeed;
    [SerializeField]
    private float _maxXspeed;
    [SerializeField]
    private float _minYspeed;
    [SerializeField]
    private float _maxYspeed;
    [SerializeField]
    private float _difficultyMultiPlayer;

    private Rigidbody2D _rb;
    private AudioSource _audioSource;


    private void Awake() {
        
        _rb = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
        _rb.linearVelocity = new Vector2((Random.Range(_minXspeed, _maxXspeed) * (Random.value > 0.5f ? -1 : 1)), 
                                         (Random.Range(_minYspeed, _maxYspeed) * (Random.value > 0.5f ? -1 : 1)));

    }

    private void OnTriggerEnter2D(Collider2D infoAccess) {

        if (infoAccess.CompareTag("Limit")) {

            _audioSource.Play();

            if (infoAccess.transform.position.y > transform.position.y
                && _rb.linearVelocity.y > 0.0f) {


                _rb.linearVelocity = new Vector2(_rb.linearVelocity.x,
                                                 -_rb.linearVelocity.y);


            }

            //La bola colisiona con el limite inferior
            if (infoAccess.transform.position.y < transform.position.y
               && _rb.linearVelocity.y < 0.0f) {


                _rb.linearVelocity = new Vector2(_rb.linearVelocity.x,
                                                 -_rb.linearVelocity.y);

            }

        }
        else if (infoAccess.CompareTag("Paddle")) {

            _audioSource.Play();

            if (infoAccess.transform.position.x < transform.position.x
                && _rb.linearVelocity.x < 0.0f) { 
            
                _rb.linearVelocity = new Vector2(-_rb.linearVelocity.x * _difficultyMultiPlayer,
                                                 _rb.linearVelocity.y * _difficultyMultiPlayer);

            }

            if (infoAccess.transform.position.x > transform.position.x
                && _rb.linearVelocity.x > 0.0f) {

                _rb.linearVelocity = new Vector2(-_rb.linearVelocity.x * _difficultyMultiPlayer,
                                                 _rb.linearVelocity.y * _difficultyMultiPlayer);

            }

        }

    }


}
