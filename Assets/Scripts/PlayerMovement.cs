using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour{
    //Creating a new instance of PlayerInputMaps to handle player input
    private PlayerInputMaps playerInput;

    //Getting a reference of the rigid body
    private Rigidbody rb;

    //Variables the movement 
    private Vector3 movement;
    [SerializeField] private int moveSpeed;
    [SerializeField] private int jumpStrength;

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
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    private void Start(){
        //subscribing methods to the playerInput
        playerInput.Player.Movement_Walking.performed += OnMovementPerformed;
        playerInput.Player.Movement_Walking.canceled += OnMovementCanceled;
    }

    private void FixedUpdate(){
        //Move the player around 
        rb.velocity = movement * moveSpeed;
    }




    private void OnMovementPerformed(InputAction.CallbackContext ctx){
        //Setting movement to the value of ctx
        movement = ctx.ReadValue<Vector3>();
    }
    private void OnMovementCanceled(InputAction.CallbackContext ctx){
        //Setting movement to zero when no movement is detected
        movement = Vector3.zero;
    }
}
