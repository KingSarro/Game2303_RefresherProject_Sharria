using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PuddleLogic : MonoBehaviour{
    [SerializeField] private int damageAmount;
    private bool inCorotine = false;
    private bool runCoroutine = false;

    [SerializeField] private UnityEvent OnEnter;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.GetComponent<PlayerMovement>() != null){
            //Triggers the UnityEvent
            OnEnter?.Invoke();
            //Damage Player
                //Calls a CoRoutine for damage over time
        }
    }
}
