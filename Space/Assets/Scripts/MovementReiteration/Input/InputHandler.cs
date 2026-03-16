using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [Serializable]
    public struct KeyBinding
    {
        public KeyCode keyCode;
        public BaseCommand command;
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
                BaseCommand command = keyBinding.command;
                command.Execute();
            }
            if (Input.GetKeyDown(keyBinding.keyCode))
            {
                BaseCommand command = keyBinding.command;
                command.ExecuteDown();
            }
            if (Input.GetKeyUp(keyBinding.keyCode))
            {
                BaseCommand command = keyBinding.command;
                command.ExecuteUp();
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