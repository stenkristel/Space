using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float minimumYSpeed;
    [SerializeField] private float maximumYSpeed;
    [SerializeField] private Rigidbody rigidBody;
    
    [SerializeField] private MinMaxEventStruct[] speedSprites;

    private float _yVelocity;

    private void FixedUpdate()
    {
        var movementChange = _yVelocity * Time.deltaTime;
        transform.position += new Vector3(0f, movementChange, 0f);
    }

    public void MoveHorizontal(float speed)
    {
        var movementChange = speed * Time.deltaTime;
        transform.position += new Vector3(movementChange, 0, 0);
    }

    public void SetVerticalSpeed(float speed)
    {
        if (rigidBody.velocity.y + speed < minimumYSpeed)
        {
            speed = minimumYSpeed;
        }

        if (rigidBody.velocity.y + speed > maximumYSpeed)
        {
            speed = maximumYSpeed;
        }

        CheckForSpeedSpritesChange(speed);
        _yVelocity = speed;
    }
    
    public void EditVerticalSpeed(float speed)
    {
        speed += rigidBody.velocity.y;
        SetVerticalSpeed(speed);
    }

    public void StartMovingFromStandStill(float speed)
    {
        if (_yVelocity <= 0f) SetVerticalSpeed(speed);
    }

    public void CheckForSpeedSpritesChange(float speed)
    {
        foreach (var speedRange in speedSprites)
        {
            if (speed < speedRange.MinValue || speed > speedRange.MaxValue)
            {
                continue;
            }

            speedRange.onInRange?.Invoke();
        }
    }
}
