using UnityEngine;

public class MouseEvents : MonoBehaviour
{

    private void OnMouseDown() {

        Debug.Log("Actuo cuando hago clic con el boton izquierdo del raton" +
                  " encima del collider");

    }

    private void OnMouseOver() {

        Debug.Log("Actuo cuando el raton esta encima del collider");
                  

    }

    private void OnMouseEnter() {

        Debug.Log("Actuo cuando entro en el collider");
                  

    }

    private void OnMouseExit() {

        Debug.Log("Actuo cuando salgo del collider");
                 

    }

    private void OnMouseDrag() {

        Debug.Log("Actuo cuando arrastro el raton por el collider");


    }

}
