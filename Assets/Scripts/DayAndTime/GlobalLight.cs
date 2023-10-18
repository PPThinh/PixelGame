using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Light2D))]
public class GlobalLight : MonoBehaviour
{
    private Light2D _light;
    [SerializeField] private GlobalTime globalTime;
    [SerializeField] private Gradient gradientColor;

    private void Awake()
    {
        _light = GetComponent<Light2D>();
        globalTime.globalTimeChanged += OnGlobalTimeChanged;

    }

    private void OnDestroy()
    {
        globalTime.globalTimeChanged -= OnGlobalTimeChanged;
    }

    private void OnGlobalTimeChanged(object sender, TimeSpan newTime)
    {
        _light.color = gradientColor.Evaluate(PercentOfDay(newTime));
    }

    private float PercentOfDay(TimeSpan timeSpan)
    {
        return (float)timeSpan.TotalMinutes % GlobalTimeContants.minutesInDay / GlobalTimeContants.minutesInDay;
    }
}
