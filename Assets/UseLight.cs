using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseLight : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Create a new GameObject and attach the script to it.
        GameObject DayNightCycle = new GameObject();
        DayNightCycle.AddComponent<DayNightCycle>();

        // Set the gradient colors.
        Color[] gradientColors = {
    new Color(0.0f, 0.0f, 0.0f),
    new Color(0.5f, 0.5f, 0.5f),
    new Color(1.0f, 1.0f, 1.0f)
};
        DayNightCycle.GetComponent<DayNightCycle>().gradientColors = gradientColors;

        // Set the time of day.
        DayNightCycle.GetComponent<DayNightCycle>().timeOfDay = 6.0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
