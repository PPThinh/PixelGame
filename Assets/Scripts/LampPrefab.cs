using System;
using System.Collections.Generic;
using UnityEngine;

public class LampPrefab : MonoBehaviour
{
    public GameObject lampPrefab;

    private void Start()
    {
        Instantiate(lampPrefab);
    }

    public Vector3 GetLampPosition()
    {
        return lampPrefab.transform.position;
    }
} 