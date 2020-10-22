using System;
using System.Collections;
using System.Collections.Generic;
using PlayerSpace;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerShootingController))]
[RequireComponent(typeof(PlayerMovementController))]
public class PlayerControls : MonoBehaviour
{
    private PlayerMovementController _movementController;
    private PlayerShootingController _shootingController;

    private void Start()
    {
        _movementController = GetComponent<PlayerMovementController>();
        _shootingController = GetComponent<PlayerShootingController>();
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        _movementController.MovInput = ctx.ReadValue<Vector2>();
    }

    public void OnShoot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            _shootingController.Shoot();
        }
    }
}
