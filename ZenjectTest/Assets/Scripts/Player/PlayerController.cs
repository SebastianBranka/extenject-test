using System;
using UnityEngine;

public class PlayerController
{
    public PlayerController(IInputService input)
    {
        input.OnMovePerformed += HandleMove;
    }

    private void HandleMove(float direction)
    {
        Debug.Log($"Player moving in direction: {direction}");
    }

    public void Tick()
    {
        Debug.Log($"Player Tick");
    }
}
