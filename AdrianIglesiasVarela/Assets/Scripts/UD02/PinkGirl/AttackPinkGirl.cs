using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class AttackPinkGirl : MonoBehaviour
{

    //Zona de variables globales
    [Header("Elements")]
    [SerializeField]
    private Transform _posRot;
    [SerializeField]
    private GameObject _ball;

    [Header("Physics")  ]
    [SerializeField]
    private float _thrustY;
    [SerializeField]
    private float _thrustZ;

    // Update is called once per frame
    void Update()
    {

        InputCreateBalls();

    }

    private void InputCreateBalls() {

        if (Input.GetMouseButtonDown(0)) {

            CreateBalls();

        }

    }

    private void CreateBalls() {

        GameObject cloneBall = Instantiate(_ball, _posRot.position, _posRot.rotation);
        //El componente "rigibody" con el que voy a trabajar. Es el clon de las bolas
        Rigidbody rbCloneBall = cloneBall.GetComponent<Rigidbody>();
        //"Vector3.up" hace referencia a la "y" global de la escena
        rbCloneBall.AddForce(Vector3.up * _thrustY);
        //"transfom.forward" hace referencia al eje z local del "posRot"
        rbCloneBall.AddForce(transform.forward * _thrustZ);


    }

}
