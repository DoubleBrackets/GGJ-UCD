//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Input/MainInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MainInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInput"",
    ""maps"": [
        {
            ""name"": ""PlayerInput"",
            ""id"": ""5c79aac1-cef7-4a38-b954-069bc98ef41a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""45350468-2be1-4dea-9ee9-bd551af1740d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""Value"",
                    ""id"": ""3e166514-aaf4-445d-a4d5-7388211922fd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ToggleDriftState"",
                    ""type"": ""Button"",
                    ""id"": ""91ce4117-20f4-4aab-b585-34c694ff9b89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LH1"",
                    ""type"": ""Button"",
                    ""id"": ""fb49d106-9e0f-4519-98d4-b2cc6799782b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LH2"",
                    ""type"": ""Button"",
                    ""id"": ""c15d8611-fe6e-4f56-aad5-8052a6dbb5c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LH3"",
                    ""type"": ""Button"",
                    ""id"": ""357f04eb-f528-4850-b9d2-53209d6db4ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LH4"",
                    ""type"": ""Button"",
                    ""id"": ""0cb11f65-7ffc-4deb-8118-f073334d2dfb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LH5"",
                    ""type"": ""Button"",
                    ""id"": ""b2bb740d-2340-4118-b42e-a2e1a018ca4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LH6"",
                    ""type"": ""Button"",
                    ""id"": ""299827d5-1edb-4808-9967-5ee296ae6db4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LH7"",
                    ""type"": ""Button"",
                    ""id"": ""6abe3435-fa60-4932-be0c-4c4f319d2ad8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OctaveUp"",
                    ""type"": ""Button"",
                    ""id"": ""7e1471df-f888-427b-91d3-916a3e6907ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OctaveDown"",
                    ""type"": ""Button"",
                    ""id"": ""f0e11abd-a711-4523-bf23-0c385fd23960"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Strum"",
                    ""type"": ""Button"",
                    ""id"": ""f6ea43d3-92c6-4ce7-a3c0-e0ffe72d17a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Strum2"",
                    ""type"": ""Button"",
                    ""id"": ""97252da4-1a19-481e-a68f-a9df2a595ba9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ebee8857-b4a3-4c66-a1d5-c52ddc136cb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c0391a2a-dea6-440c-970b-4068bf31a71d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a127d4f0-c5c4-40be-8f3c-a307c8cbcf61"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""10c8c7e8-bd5e-4d00-89af-30d0cd2b5911"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""14d437cd-9cb2-4370-a8b5-64334a01d158"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f514731a-d17f-4fe5-8681-06ef7eeb95ba"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cc4ac1b6-02c5-4d53-ab69-958c95f306df"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ee102ef-ea0d-4fbf-bccb-4fcf2fd1770f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleDriftState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f628390d-3c12-45de-8bba-34dda5b3832e"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LH1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""633e840f-86de-4cb5-bdba-f655da846b90"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LH2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2aa36b34-2c6d-4d1a-a93e-c46b3d15b0e2"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LH3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b088593b-7384-4153-98c3-6aafa90fa840"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LH4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e11f29e4-8c4e-441d-9c96-c588cbafda0d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LH5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82308cd8-1b36-4562-8a92-b7d0f407dd0f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OctaveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a71bfb59-4ed5-4630-8879-609a1072a443"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OctaveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4efaaf2d-6553-4688-a48a-690bd4c1a0d7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strum"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0d98225-ffe7-4f06-9346-ee2ce98745db"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strum2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82e44fc0-1adb-4568-88cc-07415bc963cd"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LH6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be5fb3fd-f1d4-46a4-adbf-bbfda3f74cdf"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LH7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56dcc718-5b35-4d96-a3f0-c37a3732c45b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_Movement = m_PlayerInput.FindAction("Movement", throwIfNotFound: true);
        m_PlayerInput_MouseLook = m_PlayerInput.FindAction("MouseLook", throwIfNotFound: true);
        m_PlayerInput_ToggleDriftState = m_PlayerInput.FindAction("ToggleDriftState", throwIfNotFound: true);
        m_PlayerInput_LH1 = m_PlayerInput.FindAction("LH1", throwIfNotFound: true);
        m_PlayerInput_LH2 = m_PlayerInput.FindAction("LH2", throwIfNotFound: true);
        m_PlayerInput_LH3 = m_PlayerInput.FindAction("LH3", throwIfNotFound: true);
        m_PlayerInput_LH4 = m_PlayerInput.FindAction("LH4", throwIfNotFound: true);
        m_PlayerInput_LH5 = m_PlayerInput.FindAction("LH5", throwIfNotFound: true);
        m_PlayerInput_LH6 = m_PlayerInput.FindAction("LH6", throwIfNotFound: true);
        m_PlayerInput_LH7 = m_PlayerInput.FindAction("LH7", throwIfNotFound: true);
        m_PlayerInput_OctaveUp = m_PlayerInput.FindAction("OctaveUp", throwIfNotFound: true);
        m_PlayerInput_OctaveDown = m_PlayerInput.FindAction("OctaveDown", throwIfNotFound: true);
        m_PlayerInput_Strum = m_PlayerInput.FindAction("Strum", throwIfNotFound: true);
        m_PlayerInput_Strum2 = m_PlayerInput.FindAction("Strum2", throwIfNotFound: true);
        m_PlayerInput_Jump = m_PlayerInput.FindAction("Jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private IPlayerInputActions m_PlayerInputActionsCallbackInterface;
    private readonly InputAction m_PlayerInput_Movement;
    private readonly InputAction m_PlayerInput_MouseLook;
    private readonly InputAction m_PlayerInput_ToggleDriftState;
    private readonly InputAction m_PlayerInput_LH1;
    private readonly InputAction m_PlayerInput_LH2;
    private readonly InputAction m_PlayerInput_LH3;
    private readonly InputAction m_PlayerInput_LH4;
    private readonly InputAction m_PlayerInput_LH5;
    private readonly InputAction m_PlayerInput_LH6;
    private readonly InputAction m_PlayerInput_LH7;
    private readonly InputAction m_PlayerInput_OctaveUp;
    private readonly InputAction m_PlayerInput_OctaveDown;
    private readonly InputAction m_PlayerInput_Strum;
    private readonly InputAction m_PlayerInput_Strum2;
    private readonly InputAction m_PlayerInput_Jump;
    public struct PlayerInputActions
    {
        private @MainInput m_Wrapper;
        public PlayerInputActions(@MainInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerInput_Movement;
        public InputAction @MouseLook => m_Wrapper.m_PlayerInput_MouseLook;
        public InputAction @ToggleDriftState => m_Wrapper.m_PlayerInput_ToggleDriftState;
        public InputAction @LH1 => m_Wrapper.m_PlayerInput_LH1;
        public InputAction @LH2 => m_Wrapper.m_PlayerInput_LH2;
        public InputAction @LH3 => m_Wrapper.m_PlayerInput_LH3;
        public InputAction @LH4 => m_Wrapper.m_PlayerInput_LH4;
        public InputAction @LH5 => m_Wrapper.m_PlayerInput_LH5;
        public InputAction @LH6 => m_Wrapper.m_PlayerInput_LH6;
        public InputAction @LH7 => m_Wrapper.m_PlayerInput_LH7;
        public InputAction @OctaveUp => m_Wrapper.m_PlayerInput_OctaveUp;
        public InputAction @OctaveDown => m_Wrapper.m_PlayerInput_OctaveDown;
        public InputAction @Strum => m_Wrapper.m_PlayerInput_Strum;
        public InputAction @Strum2 => m_Wrapper.m_PlayerInput_Strum2;
        public InputAction @Jump => m_Wrapper.m_PlayerInput_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @MouseLook.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMouseLook;
                @ToggleDriftState.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnToggleDriftState;
                @ToggleDriftState.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnToggleDriftState;
                @ToggleDriftState.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnToggleDriftState;
                @LH1.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH1;
                @LH1.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH1;
                @LH1.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH1;
                @LH2.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH2;
                @LH2.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH2;
                @LH2.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH2;
                @LH3.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH3;
                @LH3.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH3;
                @LH3.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH3;
                @LH4.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH4;
                @LH4.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH4;
                @LH4.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH4;
                @LH5.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH5;
                @LH5.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH5;
                @LH5.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH5;
                @LH6.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH6;
                @LH6.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH6;
                @LH6.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH6;
                @LH7.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH7;
                @LH7.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH7;
                @LH7.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnLH7;
                @OctaveUp.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnOctaveUp;
                @OctaveUp.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnOctaveUp;
                @OctaveUp.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnOctaveUp;
                @OctaveDown.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnOctaveDown;
                @OctaveDown.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnOctaveDown;
                @OctaveDown.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnOctaveDown;
                @Strum.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnStrum;
                @Strum.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnStrum;
                @Strum.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnStrum;
                @Strum2.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnStrum2;
                @Strum2.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnStrum2;
                @Strum2.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnStrum2;
                @Jump.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
                @ToggleDriftState.started += instance.OnToggleDriftState;
                @ToggleDriftState.performed += instance.OnToggleDriftState;
                @ToggleDriftState.canceled += instance.OnToggleDriftState;
                @LH1.started += instance.OnLH1;
                @LH1.performed += instance.OnLH1;
                @LH1.canceled += instance.OnLH1;
                @LH2.started += instance.OnLH2;
                @LH2.performed += instance.OnLH2;
                @LH2.canceled += instance.OnLH2;
                @LH3.started += instance.OnLH3;
                @LH3.performed += instance.OnLH3;
                @LH3.canceled += instance.OnLH3;
                @LH4.started += instance.OnLH4;
                @LH4.performed += instance.OnLH4;
                @LH4.canceled += instance.OnLH4;
                @LH5.started += instance.OnLH5;
                @LH5.performed += instance.OnLH5;
                @LH5.canceled += instance.OnLH5;
                @LH6.started += instance.OnLH6;
                @LH6.performed += instance.OnLH6;
                @LH6.canceled += instance.OnLH6;
                @LH7.started += instance.OnLH7;
                @LH7.performed += instance.OnLH7;
                @LH7.canceled += instance.OnLH7;
                @OctaveUp.started += instance.OnOctaveUp;
                @OctaveUp.performed += instance.OnOctaveUp;
                @OctaveUp.canceled += instance.OnOctaveUp;
                @OctaveDown.started += instance.OnOctaveDown;
                @OctaveDown.performed += instance.OnOctaveDown;
                @OctaveDown.canceled += instance.OnOctaveDown;
                @Strum.started += instance.OnStrum;
                @Strum.performed += instance.OnStrum;
                @Strum.canceled += instance.OnStrum;
                @Strum2.started += instance.OnStrum2;
                @Strum2.performed += instance.OnStrum2;
                @Strum2.canceled += instance.OnStrum2;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
    public interface IPlayerInputActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
        void OnToggleDriftState(InputAction.CallbackContext context);
        void OnLH1(InputAction.CallbackContext context);
        void OnLH2(InputAction.CallbackContext context);
        void OnLH3(InputAction.CallbackContext context);
        void OnLH4(InputAction.CallbackContext context);
        void OnLH5(InputAction.CallbackContext context);
        void OnLH6(InputAction.CallbackContext context);
        void OnLH7(InputAction.CallbackContext context);
        void OnOctaveUp(InputAction.CallbackContext context);
        void OnOctaveDown(InputAction.CallbackContext context);
        void OnStrum(InputAction.CallbackContext context);
        void OnStrum2(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}