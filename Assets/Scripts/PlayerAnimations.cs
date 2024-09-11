using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour{

    //Create Reference for an animation controller
    [SerializeField] private Animator animator;
    //Create reference to player movement script
    private PlayerMovement playerMovement;



    // Start is called before the first frame update
    void Start(){
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update(){
        animator.SetFloat("walkMovement", playerMovement.getMovement());
    }
}
