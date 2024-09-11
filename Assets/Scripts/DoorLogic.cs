using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogic : MonoBehaviour{
    private Vector3 closedPosition;
    [SerializeField] private Vector3 openPosition;


    // Start is called before the first frame update
    void Start(){
        closedPosition = transform.position;
    }


    public Vector3 getClosedPosition(){
        return closedPosition;
    }
    public Vector3 getOpenPosition(){
        return openPosition;
    }

    public void setDoorPosition(Vector3 pos){
        transform.position = pos;
    }
}
