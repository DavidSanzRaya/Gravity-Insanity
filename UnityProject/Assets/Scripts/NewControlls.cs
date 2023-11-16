using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewControlls : MonoBehaviour
{
    private PlayerInputActions playerActions;
    public float moveValue;
    private Player player;
    private MovementBehaviour mvb;
    private Animator anim;

    private void Awake()
    {
        playerActions = new PlayerInputActions();
        playerActions.Player.Run.performed += OnRun;
        playerActions.Player.Run.canceled += OnStopRun;
        playerActions.Player.Jump.started += OnFlip;
        playerActions.Player.GodMode.started += OnGodMode;
        mvb = GetComponent<MovementBehaviour>();
        anim = GetComponent<Animator>();
        player = GetComponent<Player>();
    }

    private void OnRun(InputAction.CallbackContext ctx)
    {
        moveValue = ctx.ReadValue<float>();
    }

    private void OnStopRun(InputAction.CallbackContext ctx)
    {
        moveValue = 0;
    }

    private void OnFlip(InputAction.CallbackContext ctx)
    {
        mvb.Flip();
        anim.SetTrigger("jump");
    }

    private void OnGodMode(InputAction.CallbackContext ctx)
    {
        player.GodMode();
    }

    private void OnEnable()
    {
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }
}
