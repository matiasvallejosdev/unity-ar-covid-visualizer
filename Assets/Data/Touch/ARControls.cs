// GENERATED AUTOMATICALLY FROM 'Assets/Data/Touch/ARControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ARControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ARControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ARControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e84e4395-91ca-418e-8653-a56fb9370526"",
            ""actions"": [
                {
                    ""name"": ""Toggle Console"",
                    ""type"": ""Button"",
                    ""id"": ""97fb96cc-8c62-4533-890c-9b09f4f176bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6835ab99-f0a4-4af9-9064-1f927e8dee70"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Toggle Console"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_ToggleConsole = m_Player.FindAction("Toggle Console", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_ToggleConsole;
    public struct PlayerActions
    {
        private @ARControls m_Wrapper;
        public PlayerActions(@ARControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleConsole => m_Wrapper.m_Player_ToggleConsole;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @ToggleConsole.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleConsole;
                @ToggleConsole.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleConsole;
                @ToggleConsole.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleConsole;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleConsole.started += instance.OnToggleConsole;
                @ToggleConsole.performed += instance.OnToggleConsole;
                @ToggleConsole.canceled += instance.OnToggleConsole;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnToggleConsole(InputAction.CallbackContext context);
    }
}
