using UnityEngine;

public class EnemyPlayer : MonoBehaviour
{

    private void OnTriggerEnter(Collider infoAccess) {

        if (infoAccess.CompareTag("AttackPlayer")) { 
        
            Destroy(gameObject);
        
        }

    }

}
