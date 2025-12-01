using UnityEngine;

public class LookAtCube : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private Transform _myCube;

    // Update is called once per frame
    void Update()
    {

        LookCube();

    }

    private void LookCube() { 
    
        transform.LookAt(_myCube);
    
    }

}
