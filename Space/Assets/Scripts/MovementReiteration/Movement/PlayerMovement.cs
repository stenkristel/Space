using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    public float Ymovement;
    
    [SerializeField] private float minimumYSpeed;
    [SerializeField] private float maximumYSpeed;
    [SerializeField] private Rigidbody rigidBody;
    
    [SerializeField] private MinMaxEventStruct[] speedSprites;
    
    /*[SerializeField] private GameObject SpriteFast;
    [SerializeField] private GameObject SpriteMedium;
    [SerializeField] private GameObject SpriteSlow;
    [SerializeField] private GameObject BigFlameSmallest;
    [SerializeField] private GameObject BigFlame;
    [SerializeField] private GameObject LeftSmallFlame;
    [SerializeField] private GameObject RigthSmallFlame;
    [SerializeField] private GameObject LeftSmallestFlame;
    [SerializeField] private GameObject RigthSmallestFlame;*/

    public void MoveHorizontal(float speed)
    {
        var movementChange = speed * Time.deltaTime;
        rigidBody.transform.position += new Vector3(movementChange, 0, 0);
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
        rigidBody.velocity = new Vector3(0, speed, 0);
    }
    
    public void EditVerticalSpeed(float speed)
    {
        speed += rigidBody.velocity.y;
        SetVerticalSpeed(speed);
    }

    public void StartMovingFromStandStill(float speed)
    {
        if (Ymovement <= 0) SetVerticalSpeed(speed);
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

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag.Equals("Meteorite"))
        {
            Ymovement -= 0.7f; 
            
        }
        if (targetObj.gameObject.tag.Equals("ufo"))
        {
            Ymovement -= 1f;
            
        }

        if (targetObj.gameObject.tag.Equals("SpeedBoost"))
        {
            Ymovement += 0.5f;
            
        }
        if (targetObj.gameObject.tag.Equals("BigSpeedBoost"))
        {
            Ymovement += 1f;
            
        }

        if (targetObj.gameObject.tag.Equals("Rat"))
        {
            StartCoroutine(waiter());
        }

    }
    IEnumerator waiter()
    {
        Ymovement -= 1.5f;
        yield return new WaitForSeconds(1.5f);
        Ymovement += 1.5f;
    }
}
