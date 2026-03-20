using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private UnityEvent onStart;
    [SerializeField] private UnityEvent onEnd;

    public void StartTimer(float timerLength)
    {
        StartCoroutine(TimerCoroutine(timerLength));
    }
    
    public IEnumerator TimerCoroutine(float timerLength)
    {
        onStart?.Invoke();
        yield return new WaitForSeconds(timerLength);
        onEnd?.Invoke();
    }
}
