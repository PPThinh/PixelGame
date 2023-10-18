using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[RequireComponent(typeof(TMP_Text))]
public class DisplayGlobalTime : MonoBehaviour
{
    [SerializeField] private GlobalTime globalTime;
    private TMP_Text text;
    // Start is called before the first frame update
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        globalTime.globalTimeChanged += OnGlobalChanged;

    }

    private void OnGlobalChanged(object sender, TimeSpan newTime)
    {
        text.SetText(newTime.ToString(@"hh\:mm"));
    }

    private void OnDestroy()
    {
        globalTime.globalTimeChanged -= OnGlobalChanged;
    }

}
