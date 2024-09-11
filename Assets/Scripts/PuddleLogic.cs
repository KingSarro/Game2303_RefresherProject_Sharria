using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PuddleLogic : MonoBehaviour{
    [SerializeField] private int damageAmount;
    private PlayerData pData;
    //private bool isInCorotine = false;
    [SerializeField] private bool playerInTrigger = false;

    //[SerializeField] private UnityEvent OnPlayerEnter;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.GetComponent<PlayerMovement>() != null){
            if (other.GetComponent<PlayerData>() == true){
                pData = other.GetComponent<PlayerData>();

                //isInCorotine = true;
                playerInTrigger = true;

                StartCoroutine(DamageOverTime(pData));
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.GetComponent<PlayerMovement>() != null){
            if (other.GetComponent<PlayerData>() == true){
                pData = null;
                //isInCorotine = false;
                playerInTrigger = false;
                Debug.Log("In Routine : " + Time.time);
            }
        }
    }

    private IEnumerator DamageOverTime(PlayerData player) {
        while(playerInTrigger == true){
            yield return new WaitForSeconds(2f);
            player?.SetHealth(damageAmount);
        }


    }
}
