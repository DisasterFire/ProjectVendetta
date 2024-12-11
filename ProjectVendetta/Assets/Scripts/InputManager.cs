using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls controls;
    PlayerControls.MoveAndShootActions actions;
    Vector2 hInput; //Input for movement
    Vector2 vInput;

    Vector2 shootIn;
    Vector2 hAimIn;
    Vector2 vAimIn;

    [SerializeField] Movement movement;
    [SerializeField] Shooting shooting;
    [SerializeField] Aiming aiming;

    private void Awake()
    {
        controls = new PlayerControls();
        actions = controls.MoveAndShoot;

        actions.Movement.performed += ctx => hInput = ctx.ReadValue<Vector2>();
        actions.Movement.performed += ctx => vInput = ctx.ReadValue<Vector2>();

        actions.Shoot.performed += ctx => shootIn = ctx.ReadValue<Vector2>();

        actions.Aiming.performed += ctx => hAimIn = ctx.ReadValue<Vector2>();
        actions.Aiming.performed += ctx => vAimIn = ctx.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Update()
    {
        movement.ReceiveInput(hInput);
        movement.ReceiveInput(vInput);

        shooting.ReceiveInput(shootIn);

        aiming.ReceiveInput(hAimIn);
        aiming.ReceiveInput(vAimIn);
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
