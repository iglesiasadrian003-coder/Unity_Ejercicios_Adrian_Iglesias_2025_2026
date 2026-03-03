using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{

    //Zona de varaiables globales
    [SerializeField]
    private GameObject _ballPrefab;
    [SerializeField]
    private TextMeshProUGUI _scoreTextOne;
    [SerializeField]
    private TextMeshProUGUI _scoreTextTwo;
    [SerializeField]
    private float _pointMatch;

    private BallMovement _ballMovementScript;
    private int _scoreOne;
    private int _scoreTwo;


    private void Awake() {
        
        SpawnBall();

    }

    private void SpawnBall() {

        GameObject cloneBall = Instantiate(_ballPrefab, transform.position, transform.rotation);

        _ballMovementScript = cloneBall.GetComponent<BallMovement>();
        _ballMovementScript.transform.position = Vector3.zero;

        _scoreTextOne.text = _scoreOne.ToString();
        _scoreTextTwo.text = _scoreTwo.ToString();

    }

    private void Update() {

        SetPoint();

    }

    private void SetPoint() {

        if (_ballMovementScript != null) {

            if (_ballMovementScript.transform.position.x > _pointMatch) {

                _scoreOne++;
                Destroy(_ballMovementScript.gameObject);
                SpawnBall();
            
            }
        
        }

        if (_ballMovementScript != null) {

            if (_ballMovementScript.transform.position.x < -_pointMatch) {

                _scoreTwo++;
                Destroy(_ballMovementScript.gameObject);
                SpawnBall();

            }

        }

    }
    
}
