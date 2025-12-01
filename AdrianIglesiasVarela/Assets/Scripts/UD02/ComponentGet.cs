using UnityEngine;

public class ComponentGet : MonoBehaviour
{

    //Zona de variables globales
    private Light _myligth;
    [SerializeField]
    private BoxCollider _myCubeCollider;

    private void Awake() {

        //Inicializacion del componente "Light" porque mi "gameObject" tiene ese componente
        _myligth = GetComponent<Light>();
    
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        _myligth.enabled = true;
        _myCubeCollider.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
