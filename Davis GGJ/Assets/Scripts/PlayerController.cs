using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Dependencies
    public BasicCharacterController PlayerCharacterController;
    public ThirdPersonCameraScript TPCameraScript;
    public Transform MeshTransform;
    //Fields
    public float MovementSpeed;
    public float JumpVel;
    public bool IsInDrift{ get => isInDrift; set => isInDrift = value; }
    //Input
    public Vector2Reference MovementInput;
    private bool isInDrift = false;
    private Vector3 driftVel;

    //Events
    public GameEvent PlayerDriftInterrupt;

    //Tiemrs
    private float jumpTimer = 0f;
    private void Update()
    {
        if(!IsInDrift)
            Movement();
        else
        {
            DriftMovement();
        }
        jumpTimer -= Time.deltaTime;
    }

    public void TryJump()
    {
        if(jumpTimer <= 0)
        {
            jumpTimer = 0.15f;
            PlayerCharacterController.Jump(JumpVel);
        }
    }

    private void Movement()
    {
        Vector3 movementVector = MovementSpeed * MovementInput.Value.normalized.ToVector3Y();
        movementVector = Quaternion.AngleAxis(TPCameraScript.hRotation, Vector3.up) * movementVector;
        PlayerCharacterController.SetVelocityHorizontal(movementVector);
    }

    private void DriftMovement()
    {
        if (PlayerCharacterController.horizontalVelocity.magnitude < MovementSpeed - 1f)
            PlayerDriftInterrupt.Invoke();
        if (!TPCameraScript.HasLockTarget)
        {
            PlayerCharacterController.SetVelocityHorizontal(PlayerCharacterController.horizontalVelocity.normalized.ToVector3Y() * MovementSpeed * 1.35f);
            return;
        }
        Vector3 right = Quaternion.Euler(0, TPCameraScript.hRotation - 85, 0) * Vector3.forward;
        Vector3 left = Quaternion.Euler(0, TPCameraScript.hRotation +  85, 0) * Vector3.forward;
        float mag1 = (right - PlayerCharacterController.horizontalVelocity.ToVector3Y()).magnitude;
        float mag2 = (left - PlayerCharacterController.horizontalVelocity.ToVector3Y()).magnitude;
        driftVel = (mag1 > mag2 ? left : right);
        PlayerCharacterController.SetVelocityHorizontal(driftVel * MovementSpeed);
    }

    private void FixedUpdate()
    {
        if(!IsInDrift)
            RotatePlayer();
        else
        {
            RotatePlayerToCam();
        }
    }

    private void RotatePlayer()
    {
        if (MovementInput.Value == Vector2.zero)
            return;
        MeshTransform.rotation = Quaternion.Euler(
            0,
            MeshTransform.eulerAngles.y.AngleLerp(TPCameraScript.hRotation + 90 - Mathf.Rad2Deg * Mathf.Atan2(MovementInput.Value.y, MovementInput.Value.x), Time.fixedDeltaTime * 15f),
            0);
    }
    private void RotatePlayerToCam()
    {
        MeshTransform.rotation = Quaternion.Euler(
            0,
            MeshTransform.eulerAngles.y.AngleLerp(TPCameraScript.hRotation, Time.fixedDeltaTime * 15f),
            0);
    }

}
