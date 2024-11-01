// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""OnFoot"",
            ""id"": ""c4b59bf7-2855-4410-8f65-6bd7730c832a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""e4121189-3bf6-4a16-a9c6-5a914ea20fef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3f67df13-1e1d-47e7-b4a8-f7573ad7a803"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b9ae7780-e6c1-4262-ac89-0107cb1805c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""ce07bde9-db13-45e0-90b8-7f8522da231b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DJump"",
                    ""type"": ""Button"",
                    ""id"": ""412352df-f81f-4e80-a327-4d2cd98fc564"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""c4b2a6e8-d7ea-437d-ba10-754444be161a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""fent"",
                    ""type"": ""Button"",
                    ""id"": ""08dae2f9-81ac-4e5a-ad00-459e929d9335"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""grapple"",
                    ""type"": ""Button"",
                    ""id"": ""4442de0d-dc02-446e-9123-0ace192f4ffa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sens up"",
                    ""type"": ""Button"",
                    ""id"": ""ed056446-c940-437c-933f-0d74d302ff72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sens down"",
                    ""type"": ""Button"",
                    ""id"": ""64e2b3d6-5a3a-423b-8a6b-272243635d28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""057ce212-5237-44c4-928e-f57ada8b69fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""58757c94-a341-4e04-b615-4ed50ea6890d"",
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
                    ""id"": ""9020ad18-2984-4f13-a6c5-f37a22923503"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b3b720e0-2151-4c87-9f84-59daa98f1aff"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d2909ecd-8302-4365-aadb-c794f34c56a5"",
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
                    ""id"": ""2785bafc-e5e3-4dc1-a5e9-83599fdc50d2"",
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
                    ""id"": ""0ec5dcf6-dd27-4836-b6bd-ae553054f9d0"",
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
                    ""id"": ""60ceb5b0-ed42-4e9c-8314-c9ffeb9ce2a1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cf24300-d168-4941-a143-43b7c96f5ae1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4dfc9f4-2c48-4f0c-a7b3-c998ae37f7e5"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63e1aa1c-f5ba-4275-afd9-e50b9d7adb50"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be07117a-59c1-411f-8386-7668f9945631"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c3bc089-3cd9-4069-886c-a871514203d7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""581d1954-a562-498c-a89d-40e15a718bee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db3a4513-d748-4c5a-a5a9-588b488654f4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e64f734-8c1b-480b-a399-03965dd35795"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d94d37b7-97a8-468e-82a5-886d13b5eba5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5996f25e-a7cc-4164-b591-4d15493004dc"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fent"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73344081-f58d-4fa6-a727-9fd71bdf400d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""grapple"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a8f9b7f-bc3a-4fb6-8ee9-12ee6f2a2536"",
                    ""path"": ""<Keyboard>/equals"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sens up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c2874ca-d911-4323-bcb7-c10fc8ebf85d"",
                    ""path"": ""<Keyboard>/minus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sens down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""294e2e4a-c18d-41a7-81fc-695e6e7ea739"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // OnFoot
        m_OnFoot = asset.FindActionMap("OnFoot", throwIfNotFound: true);
        m_OnFoot_Movement = m_OnFoot.FindAction("Movement", throwIfNotFound: true);
        m_OnFoot_Jump = m_OnFoot.FindAction("Jump", throwIfNotFound: true);
        m_OnFoot_Look = m_OnFoot.FindAction("Look", throwIfNotFound: true);
        m_OnFoot_Crouch = m_OnFoot.FindAction("Crouch", throwIfNotFound: true);
        m_OnFoot_DJump = m_OnFoot.FindAction("DJump", throwIfNotFound: true);
        m_OnFoot_Dash = m_OnFoot.FindAction("Dash", throwIfNotFound: true);
        m_OnFoot_fent = m_OnFoot.FindAction("fent", throwIfNotFound: true);
        m_OnFoot_grapple = m_OnFoot.FindAction("grapple", throwIfNotFound: true);
        m_OnFoot_sensup = m_OnFoot.FindAction("sens up", throwIfNotFound: true);
        m_OnFoot_sensdown = m_OnFoot.FindAction("sens down", throwIfNotFound: true);
        m_OnFoot_shoot = m_OnFoot.FindAction("shoot", throwIfNotFound: true);
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

    // OnFoot
    private readonly InputActionMap m_OnFoot;
    private IOnFootActions m_OnFootActionsCallbackInterface;
    private readonly InputAction m_OnFoot_Movement;
    private readonly InputAction m_OnFoot_Jump;
    private readonly InputAction m_OnFoot_Look;
    private readonly InputAction m_OnFoot_Crouch;
    private readonly InputAction m_OnFoot_DJump;
    private readonly InputAction m_OnFoot_Dash;
    private readonly InputAction m_OnFoot_fent;
    private readonly InputAction m_OnFoot_grapple;
    private readonly InputAction m_OnFoot_sensup;
    private readonly InputAction m_OnFoot_sensdown;
    private readonly InputAction m_OnFoot_shoot;
    public struct OnFootActions
    {
        private @PlayerInput m_Wrapper;
        public OnFootActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_OnFoot_Movement;
        public InputAction @Jump => m_Wrapper.m_OnFoot_Jump;
        public InputAction @Look => m_Wrapper.m_OnFoot_Look;
        public InputAction @Crouch => m_Wrapper.m_OnFoot_Crouch;
        public InputAction @DJump => m_Wrapper.m_OnFoot_DJump;
        public InputAction @Dash => m_Wrapper.m_OnFoot_Dash;
        public InputAction @fent => m_Wrapper.m_OnFoot_fent;
        public InputAction @grapple => m_Wrapper.m_OnFoot_grapple;
        public InputAction @sensup => m_Wrapper.m_OnFoot_sensup;
        public InputAction @sensdown => m_Wrapper.m_OnFoot_sensdown;
        public InputAction @shoot => m_Wrapper.m_OnFoot_shoot;
        public InputActionMap Get() { return m_Wrapper.m_OnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnFootActions set) { return set.Get(); }
        public void SetCallbacks(IOnFootActions instance)
        {
            if (m_Wrapper.m_OnFootActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnLook;
                @Crouch.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnCrouch;
                @DJump.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnDJump;
                @DJump.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnDJump;
                @DJump.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnDJump;
                @Dash.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnDash;
                @fent.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnFent;
                @fent.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnFent;
                @fent.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnFent;
                @grapple.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnGrapple;
                @grapple.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnGrapple;
                @grapple.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnGrapple;
                @sensup.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSensup;
                @sensup.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSensup;
                @sensup.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSensup;
                @sensdown.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSensdown;
                @sensdown.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSensdown;
                @sensdown.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnSensdown;
                @shoot.started -= m_Wrapper.m_OnFootActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_OnFootActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_OnFootActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_OnFootActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @DJump.started += instance.OnDJump;
                @DJump.performed += instance.OnDJump;
                @DJump.canceled += instance.OnDJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @fent.started += instance.OnFent;
                @fent.performed += instance.OnFent;
                @fent.canceled += instance.OnFent;
                @grapple.started += instance.OnGrapple;
                @grapple.performed += instance.OnGrapple;
                @grapple.canceled += instance.OnGrapple;
                @sensup.started += instance.OnSensup;
                @sensup.performed += instance.OnSensup;
                @sensup.canceled += instance.OnSensup;
                @sensdown.started += instance.OnSensdown;
                @sensdown.performed += instance.OnSensdown;
                @sensdown.canceled += instance.OnSensdown;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
            }
        }
    }
    public OnFootActions @OnFoot => new OnFootActions(this);
    public interface IOnFootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnDJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnFent(InputAction.CallbackContext context);
        void OnGrapple(InputAction.CallbackContext context);
        void OnSensup(InputAction.CallbackContext context);
        void OnSensdown(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
