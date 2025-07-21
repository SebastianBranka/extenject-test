using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputService : IInputService, InputSystem_Actions.IPlayerActions
{
    public event Action<float> OnMovePerformed = delegate { };
    private InputSystem_Actions _input;

    public InputService()
    {
        _input = new InputSystem_Actions();
        _input.Player.SetCallbacks(this);
        _input.Enable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        var horizontal = context.ReadValue<Vector2>().x;
        OnMovePerformed?.Invoke(horizontal);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        return; // Not implemented
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        return; // Not implemented
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        return; // Not implemented
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        return; // Not implemented
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        return;
    }

    public void OnPrevious(InputAction.CallbackContext context)
    {
        return;
    }

    public void OnNext(InputAction.CallbackContext context)
    {
        return;
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        return;
    }
}
