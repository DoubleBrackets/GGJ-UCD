using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, MainInput.IPlayerInputActions
{
    public Vector2Reference MovementVector;
    public Vector2Reference MouseDelta;
    public GameEvent DriftToggleEvent;
    public GameEvent Strum;
    public GameEvent OctaveUp;
    public GameEvent OctaveDown;
    public GameEvent Jump;

    //LHAnd Input Riffs
    public BoolReference[] LHRiffs;
    //input
    private MainInput mainInput;
    private Mouse mouse;

    private void Awake()
    {
        InitInputs();
    }

    private void InitInputs()
    {
        mainInput = new MainInput();
        mainInput.Enable();
        //Mouse
        mouse = Mouse.current;
        //Bindings lmao
        mainInput.PlayerInput.SetCallbacks(this);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        MovementVector.Value = context.ReadValue<Vector2>();
    }

    public void OnMouseLook(InputAction.CallbackContext context)
    {
        MouseDelta.Value = context.ReadValue<Vector2>();
    }

    public void OnToggleDriftState(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            DriftToggleEvent.Invoke();
        }
    }

    private void SetRiffInputValue(int index, InputAction.CallbackContext context)
    {
        if(context.started)
        {
            LHRiffs[index].Value = true;
        }
        else if(context.canceled)
        {
            LHRiffs[index].Value = false;
        }
    }

    #region LH riff inputs
    public void OnLH1(InputAction.CallbackContext context)
    {
        SetRiffInputValue(0, context);
    }

    public void OnLH2(InputAction.CallbackContext context)
    {
        SetRiffInputValue(1, context);
    }

    public void OnLH3(InputAction.CallbackContext context)
    {
        SetRiffInputValue(2, context);
    }

    public void OnLH4(InputAction.CallbackContext context)
    {
        SetRiffInputValue(3, context);
    }

    public void OnLH5(InputAction.CallbackContext context)
    {
        SetRiffInputValue(4, context);
    }

    public void OnLH6(InputAction.CallbackContext context)
    {
        SetRiffInputValue(5, context);
    }

    public void OnLH7(InputAction.CallbackContext context)
    {
        SetRiffInputValue(6, context);
    }

    public void OnOctaveUp(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OctaveUp.Invoke();
        }
    }

    public void OnOctaveDown(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OctaveDown.Invoke();
        }
    }

    public void OnStrum(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Strum.Invoke();
        }
    }

    public void OnStrum2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Strum.Invoke();
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Jump.Invoke();
        }
    }


    #endregion
}
