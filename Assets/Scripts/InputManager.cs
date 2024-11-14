
using UnityEngine;


public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    private PlayerMotor motor;
    private PlayerLook look;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //playermotor moves from the value from the action ong no cyap
        //motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
        //onFoot.Jump.performed += ctx => motor.Jump();
        //onFoot.DJump.performed += ctx => motor.DoubleJump();
        //onFoot.Crouch.performed += ctx => motor.Crouch();
        //onFoot.Dash.performed += ctx => motor.dash();
        //onFoot.fent.performed += ctx => motor.fent();
        //onFoot.grapple.performed += ctx => motor.grapple();
        //onFoot.sensup.performed += ctx => motor.sensup();
        //onFoot.sensdown.performed += ctx => motor.sensdown();
        //onFoot.shoot.performed += ctx => motor.shoot();
    }
    void Update(){
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
        onFoot.Jump.performed += ctx => motor.Jump();
        onFoot.DJump.performed += ctx => motor.DoubleJump();
        onFoot.Crouch.performed += ctx => motor.Crouch();
        onFoot.Dash.performed += ctx => motor.dash();
        onFoot.fent.performed += ctx => motor.fent();
        onFoot.grapple.performed += ctx => motor.grapple();
        onFoot.sensup.performed += ctx => motor.sensup();
        onFoot.sensdown.performed += ctx => motor.sensdown();
        onFoot.shoot.performed += ctx => motor.shoot();
    }
    private void LateUpdate(){
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }
    public void OnEnable(){
        onFoot.Enable();
    }
    private void OnDisable(){
        onFoot.Disable();
    }
}
