using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour{
    [SerializeField] private GameObject doorReference;
    private DoorLogic dLogic;

    [SerializeField] private float doorTimer;
    // Start is called before the first frame update
    void Start(){
        dLogic = doorReference.GetComponent<DoorLogic>();
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.GetComponent<PlayerMovement>() == true){
            if (doorReference != null){
                dLogic.setDoorPosition(dLogic.getOpenPosition());
            }
        }
    }

    private void OnCollisionExit(Collision other) {
        if (other.gameObject.GetComponent<PlayerMovement>() == true){
            if (doorReference != null){
                dLogic.setDoorPosition(dLogic.getClosedPosition());
            }
        }
    }
}
