using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Too iewahfoerihegr to write a proper state machine so this will be the faux state machine 
public class PlayerStateManager : MonoBehaviour
{
    public enum PlayerState
    {
        walking,
        drifting,
        dying
    }
    //Dependencies
    public ThirdPersonCameraScript TPCameraScript;
    public PlayerVFXManager VFXManager;
    public RiffInputHandler riffInputHandler;
    private BasicCharacterController characterController;
    private PlayerController playerController;

    //state
    private PlayerState currentState;

    //Events

    private void Awake()
    {
        currentState = PlayerState.walking;
        GetDependencies();
    }

    private void GetDependencies()
    {
        characterController = GetComponent<BasicCharacterController>();
        playerController = GetComponent<PlayerController>();
    }

    public void SetState(PlayerState state)
    {
        if (state == currentState)
            return;
        currentState = state;
        switch (state)
        {
            case PlayerState.walking:
                EnterWalkState();
                break;
            case PlayerState.drifting:
                EnterDriftState();
                break;
            case PlayerState.dying:
                break;
            default:
                break;
        }
    }

    public LayerMask LockonMask;

    private void EnterDriftState()
    {
        //Try to lock on
        playerController.IsInDrift = true;
        TPCameraScript.LockOn(LockonMask);
        riffInputHandler.RiffActive = true;
        VFXManager.StartDriftVFX();
        characterController.SetFrictionMultiplier(0);
    }

    private void EnterWalkState()
    {
        playerController.IsInDrift = false;
        TPCameraScript.UnLock();
        riffInputHandler.RiffActive = false;
        VFXManager.StopDriftVFX();
        characterController.SetFrictionMultiplier(1);
    }

    public void ToggleDrift()
    {
        if (currentState == PlayerState.drifting)
        {
            SetState(PlayerState.walking);
        }
        else if (currentState == PlayerState.walking && characterController.horizontalVelocity.magnitude > 1)
        {
            SetState(PlayerState.drifting);
        }
    }
}
