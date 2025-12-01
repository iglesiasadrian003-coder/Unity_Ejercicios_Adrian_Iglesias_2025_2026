using UnityEngine;

public class Clon : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private GameObject _acorn;
    [SerializeField]
    private Transform _posRotSquirrel;
    [SerializeField]
    private float _thrustY;
    [SerializeField]
    private float _thrustZ;
    [SerializeField]
    private float _timeDestroy;


    // Update is called once per frame
    void Update()
    {

        CreateAcorns();

    }

    private void CreateAcorns() {

        if (Input.GetMouseButtonDown(0)) { 
        
            //Instanciamos prefabricados
            GameObject cloneAcorn = Instantiate(_acorn, _posRotSquirrel.position, _posRotSquirrel.rotation);
            //El componente "rigybody" con el que voy a trabjar es el de los clones de la bellota
            Rigidbody rbAcorn = cloneAcorn.GetComponent<Rigidbody>();

            Destroy(cloneAcorn, _timeDestroy);
            //Destroy(gameObject);
            //Destroy(this);

            //Aplicamos una fuerza hacia arriba en el espacio global de la escena
            rbAcorn.AddForce(Vector3.up * _thrustY);
            //Aplicamos una fuerza hacia delante en el eje "z" local, de la propia ardilla
            rbAcorn.AddForce(transform.forward * _thrustZ);


        }

    }

}
