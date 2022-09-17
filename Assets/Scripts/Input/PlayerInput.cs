using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : BaseInput
{
    private PlayerControls controls;
    private bool activeMovementInput = false;

    private void Start()
    {
        if (controls == null)
        {
            controls = new();
        }
        controls.Player.Movement.performed += ctx => activeMovementInput = true;
        controls.Player.Movement.canceled += ctx => { activeMovementInput = false; movement.MoveCharacter(Vector2.zero); };
    }

    private void Update()
    {
        if (activeMovementInput)
        {
            movement.MoveCharacter(controls.Player.Movement.ReadValue<Vector2>());
        }
    }
}
