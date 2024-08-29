using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour{
    private PlayerInputMaps playerInput;

    private void OnEnable(){
        //Enable the player input
        playerInput.Enable();
    }

    private void OnDisable(){
        //Disable the player input
        playerInput.Disable();
    }

    private void Awake(){
        //Making a new instance of playerInputMaps
        playerInput = new PlayerInputMaps();
    }

    // Start is called before the first frame update
    void Start(){
        playerInput.Player.Movement_keyboard.performed += OnMovementPerformed;
        playerInput.Player.Movement_keyboard.canceled += OnMovementCanceled;
    }

    private void OnMovementPerformed(InputAction.CallbackContext ctx){}
    private void OnMovementCanceled(InputAction.CallbackContext ctx){}
}
