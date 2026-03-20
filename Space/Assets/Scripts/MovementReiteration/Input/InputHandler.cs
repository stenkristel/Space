using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    [Serializable]
    public struct KeyBinding
    {
        public KeyCode keyCode;
        public BaseCommand command;
        public UnityEvent onPressed;
    }

    [SerializeField] private List<KeyBinding> bindings;

    private void Update()
    {
        DetectInput();
    }

    private void DetectInput()
    {
        if (!Input.anyKey) return;
        for (int i = 0; i < bindings.Count; i++)
        {
            var keyBinding = bindings.ElementAt(i);
            if (Input.GetKey(keyBinding.keyCode))
            {
                keyBinding.command?.Execute();
                keyBinding.onPressed?.Invoke();
            }
            if (Input.GetKeyDown(keyBinding.keyCode))
            {
                keyBinding.command?.Execute();
                keyBinding.onPressed?.Invoke();
            }
            if (Input.GetKeyUp(keyBinding.keyCode))
            {
                keyBinding.command?.Execute();
                keyBinding.onPressed?.Invoke();
            }
        }
    }

    public void ChangeKeyBinding(BaseCommand command, KeyCode newKeyCode)
    {
        for (int i = bindings.Count - 1; i >= 0; i--)
        {
            var binding = bindings[i];
            if (binding.command == command) binding.keyCode = newKeyCode;
            bindings.Add(binding);
            bindings.Remove(bindings[i]);
        }
    }
}