using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls controls;
    PlayerControls.MoveAndShootActions actions;
    Vector2 hInput; //Input for movement
    Vector2 vInput;

    Vector2 vertIn; //Vertical Input for the shooting
    Vector2 horIn; //Horizontal Input for the shooting

    [SerializeField] Movement movement;

    private void Awake()
    {
        controls = new PlayerControls();
        actions = controls.MoveAndShoot;

        actions.Movement.performed += ctx => hInput = ctx.ReadValue<Vector2>();
        actions.Movement.performed += ctx => vInput = ctx.ReadValue<Vector2>();

        actions.HorShoot.performed += ctx => horIn = ctx.ReadValue<Vector2>();
        actions.VertShoot.performed += ctx => vertIn = ctx.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Update()
    {
        movement.ReceiveInput(hInput);
        movement.ReceiveInput(vInput);
        
    }


    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
