using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleLogic : MonoBehaviour{
    [SerializeField] private int damageAmount;
    private bool inCorotine = false;
    private bool runCoroutine = false;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.GetComponent<PlayerMovement>() != null){
            //Damage Player
                //Calls a CoRoutine for damage over time
        }
    }
}
