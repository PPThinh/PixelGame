using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTime : MonoBehaviour
{
    public event EventHandler<TimeSpan> globalTimeChanged;

    [SerializeField] private float dayLength;
    private TimeSpan currentTime;
    private float minuteLength => dayLength / GlobalTimeContants.minutesInDay;
    private IEnumerator AddMinute()
    {
        currentTime += TimeSpan.FromMinutes(1);
        globalTimeChanged?.Invoke(this, currentTime);
        yield return new WaitForSeconds(minuteLength);
        StartCoroutine(AddMinute());

    }

    private void Start()
    {
        StartCoroutine(AddMinute());
    }
}
