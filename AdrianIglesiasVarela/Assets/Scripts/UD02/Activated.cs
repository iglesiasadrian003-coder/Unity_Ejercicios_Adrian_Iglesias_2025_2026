using UnityEngine;

public class Activated : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private GameObject _myCamera;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        /*gameObject.SetActive(false);*/

    }

    // Update is called once per frame
    void Update()
    {

        ActivateCamera();

    }

    private void ActivateCamera() {

        if (Input.GetKeyDown(KeyCode.Space)) {

            _myCamera.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.E)) {

            _myCamera.SetActive(true);

        }

    }
}
