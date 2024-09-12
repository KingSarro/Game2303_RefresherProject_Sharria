using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour{
    [SerializeField] private PlayerAnimations playerAnimations;
    //Creating a new instance of PlayerInputMaps to handle player input
    private PlayerInputMaps playerInput;

    //Getting a reference of the rigid body
    private Rigidbody rb;

    //Variables the movement 
    private Vector3 movementWalk;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpStrength;

    private Quaternion q;

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
        playerInput.Player.Movement_Jump.started += OnJumpPerformed;
    }

    private void FixedUpdate(){
        //Applying gravity

        //Move the player around 
        //rb.velocity += movementWalk.normalized * moveSpeed;
        //! Or
        rb.velocity = new Vector3(movementWalk.x, rb.velocity.y, movementWalk.z);

        //transform.Rotate(transform.rotation.x, movementWalk.x, transform.rotation.z);
        if (movementWalk != Vector3.zero){

            //transform.forward = movementWalk;
            Quaternion qToRotation = Quaternion.LookRotation(movementWalk + transform.position, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, qToRotation, moveSpeed * Time.deltaTime);
        }
    }



    //---Methods meant to track the player's movement---//
    //This method will be called when the player is pressing a movement key;
    private void OnMovementPerformed(InputAction.CallbackContext ctx){
        //Setting movement to the value of ctx
        movementWalk = ctx.ReadValue<Vector3>();
    }
    //This method will be called when the player releases all/any of the movement keys
    private void OnMovementCanceled(InputAction.CallbackContext ctx){
        //Setting movement to zero when no movement is detected
        movementWalk = Vector3.zero;
    }
    //This method will be called when the player presses the space bar
    private void OnJumpPerformed(InputAction.CallbackContext ctx){
        //Jumping when the jump button is pressed
        //movementJump = 1 * jumpStrength;
        rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
    }

    public PlayerInputMaps getInputMap(){
        return playerInput;
    }

    public float getMovement(){
        return Mathf.Clamp01( Mathf.Abs(movementWalk.x) + Mathf.Abs(movementWalk.z) );
    }
}
