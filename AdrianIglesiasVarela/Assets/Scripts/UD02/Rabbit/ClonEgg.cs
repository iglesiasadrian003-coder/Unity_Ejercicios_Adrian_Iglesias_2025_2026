using UnityEngine;

public class ClonEgg : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private GameObject _egg;
    [SerializeField]
    private Transform _posRotRabbit;
    [SerializeField]
    private float _thrustY;
    [SerializeField]
    private float _thrustZ;
    [SerializeField]
    private float _timeDestroy;


    // Update is called once per frame
    void Update() {

        CreateEggs();

    }

    private void CreateEggs() {

        if (Input.GetMouseButtonDown(0)) {

            //Instanciamos prefabricados
            GameObject cloneEgg = Instantiate(_egg, _posRotRabbit.position, _posRotRabbit.rotation);
            //El componente "rigybody" con el que voy a trabjar es el de los clones de la bellota
            Rigidbody rbEgg = cloneEgg.GetComponent<Rigidbody>();

            Destroy(cloneEgg, _timeDestroy);
            //Destroy(gameObject);
            //Destroy(this);

            //Aplicamos una fuerza hacia arriba en el espacio global de la escena
            rbEgg.AddForce(Vector3.up * _thrustY);
            //Aplicamos una fuerza hacia delante en el eje "z" local, de la propia ardilla
            rbEgg.AddForce(transform.forward * _thrustZ);


        }

    }
}
