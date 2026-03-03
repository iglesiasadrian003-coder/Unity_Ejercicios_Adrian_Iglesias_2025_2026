using UnityEngine;

public class VitaminiAttack : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private VitaminiMovement _vitaminiMovementScript;
    [SerializeField]
    private float _jumpForce;

    private void OnCollisionEnter2D(Collision2D infoCollision) {

        if (infoCollision.collider.CompareTag("Ant")) {

            AttackEnemy(infoCollision.gameObject);
        
        }


    }

    private void AttackEnemy(GameObject enemy) {

        //if(_vitaminiMovementScritp == true)
        if (_vitaminiMovementScript.IsGrounded) { 
        
            return;
        
        }

        _vitaminiMovementScript.Rb.AddForce(Vector2.up * _jumpForce);
        enemy.GetComponent<Animator>().SetTrigger("Death");
        Destroy(enemy, 0.3f);
        
    }



}
