using UnityEngine;

public class AttackPinkGirlAnimator : MonoBehaviour {
    
    
    //Zona de variables globales
    private Animator _anim;
    [SerializeField]
    private Collider _colliderAttack;

    private void Awake() {

        _anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {

        InputAttack();

    }

    private void InputAttack() {

        // Si clicas o mantienes clic, activar animación
        if (Input.GetMouseButton(0)) {

            Attack();

        }

    }

    private void Attack() {

        _anim.SetTrigger("Attack");

    }

    private void OnEnableCollider() { 
        
        //Habilito el componente para el "collider" de la espada
        _colliderAttack.enabled = true;
    
    }

    private void OnDisableCollider() {

        //Deshabilito el componente para que el "collider" actue en la espada
        _colliderAttack.enabled=false;
    
    }

}
