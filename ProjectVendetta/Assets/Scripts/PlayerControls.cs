//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""MoveAndShoot"",
            ""id"": ""5c05dc1e-6632-43d2-90b0-fffb0b7512bf"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""06642325-b9ea-42a7-9f35-0ed6e1910b8e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e8aff825-cd0a-437b-852d-06d5459b702b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aiming"",
                    ""type"": ""PassThrough"",
                    ""id"": ""28cabe8b-af25-4a25-b699-d1af8885a73e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1f228861-538d-4e3f-96c9-8aab7c066890"",
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
                    ""id"": ""4b0318bb-5ce4-49c5-a8b2-07a433bea595"",
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
                    ""id"": ""7fb6f560-64b9-4caa-9cc7-c01b1be459d3"",
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
                    ""id"": ""c96c04b7-9e44-443f-98cb-8aeaf9837224"",
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
                    ""id"": ""a096812e-567e-4f08-8e53-cc61b05d14c8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""id"": ""78e0f347-9d77-40e3-a041-c16543a7beec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3d76093c-6bf1-44ef-a017-decde07b053c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2925478a-10ae-4082-9580-e534b495dbc5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac9c306f-86a2-4099-aa19-d6bd1c090bf3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""de373d5c-0919-4eeb-852e-552077137e07"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fec4d194-5428-4c8f-a029-f6d3831f600e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MoveAndShoot
        m_MoveAndShoot = asset.FindActionMap("MoveAndShoot", throwIfNotFound: true);
        m_MoveAndShoot_Movement = m_MoveAndShoot.FindAction("Movement", throwIfNotFound: true);
        m_MoveAndShoot_Shoot = m_MoveAndShoot.FindAction("Shoot", throwIfNotFound: true);
        m_MoveAndShoot_Aiming = m_MoveAndShoot.FindAction("Aiming", throwIfNotFound: true);
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

    // MoveAndShoot
    private readonly InputActionMap m_MoveAndShoot;
    private List<IMoveAndShootActions> m_MoveAndShootActionsCallbackInterfaces = new List<IMoveAndShootActions>();
    private readonly InputAction m_MoveAndShoot_Movement;
    private readonly InputAction m_MoveAndShoot_Shoot;
    private readonly InputAction m_MoveAndShoot_Aiming;
    public struct MoveAndShootActions
    {
        private @PlayerControls m_Wrapper;
        public MoveAndShootActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MoveAndShoot_Movement;
        public InputAction @Shoot => m_Wrapper.m_MoveAndShoot_Shoot;
        public InputAction @Aiming => m_Wrapper.m_MoveAndShoot_Aiming;
        public InputActionMap Get() { return m_Wrapper.m_MoveAndShoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveAndShootActions set) { return set.Get(); }
        public void AddCallbacks(IMoveAndShootActions instance)
        {
            if (instance == null || m_Wrapper.m_MoveAndShootActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MoveAndShootActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Aiming.started += instance.OnAiming;
            @Aiming.performed += instance.OnAiming;
            @Aiming.canceled += instance.OnAiming;
        }

        private void UnregisterCallbacks(IMoveAndShootActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Aiming.started -= instance.OnAiming;
            @Aiming.performed -= instance.OnAiming;
            @Aiming.canceled -= instance.OnAiming;
        }

        public void RemoveCallbacks(IMoveAndShootActions instance)
        {
            if (m_Wrapper.m_MoveAndShootActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMoveAndShootActions instance)
        {
            foreach (var item in m_Wrapper.m_MoveAndShootActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MoveAndShootActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MoveAndShootActions @MoveAndShoot => new MoveAndShootActions(this);
    public interface IMoveAndShootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAiming(InputAction.CallbackContext context);
    }
}
