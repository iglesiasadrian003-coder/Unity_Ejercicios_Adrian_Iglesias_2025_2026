using UnityEngine;

public class BallPinkGirl : MonoBehaviour
{

    [SerializeField]
    private Material _mat;

    /*private void OnCollisionEnter(Collision infoCollision) {

        Debug.Log("He colisonado con algo " + infoCollision.gameObject.name);

        //Voy a ver si estoy chocando con el cubo
        //Accedo al "collider" del objeto con el que esta chocando la bala y miro
        // si la etiqueta es igual a la de "Enemy"
        if (infoCollision.collider.CompareTag("Enemy")) { 
            
            //Cambio el material del cubo
            //Accedo a su componente "Renderer" y a su propiedad "material"
            infoCollision.gameObject.GetComponent<Renderer>().material = _mat;
        
        }

    }*/

    private void OnTriggerEnter(Collider infoAcces) {

        Debug.Log("Estoy colisionando con: " + infoAcces.gameObject.name);

        if (infoAcces.CompareTag("Enemy")) { 
            
            //Este "infoAccess" esta haciendo referencia al cubo
            Destroy(infoAcces.gameObject);
        
        }

    }

}
