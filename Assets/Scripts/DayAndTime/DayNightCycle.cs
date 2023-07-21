using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class DayNightCycle : MonoBehaviour
{
    public float timeOfDay = 0.0f;
    public Color[] gradientColors;

    void Update()
    {
        // Calculate the current gradient color.
        float gradientIndex = timeOfDay / 24.0f;
        gradientIndex = Mathf.Clamp(gradientIndex, 0.0f, 1.0f);
        Color currentColor = gradientColors[Mathf.FloorToInt(gradientIndex)];
        float lerpFactor = gradientIndex - Mathf.FloorToInt(gradientIndex);
        Color nextColor = gradientColors[Mathf.FloorToInt(gradientIndex) + 1];
        currentColor = Color.Lerp(currentColor, nextColor, lerpFactor);

        // Set the background color to the current gradient color.
        Camera.main.backgroundColor = currentColor;
    }





    //private Light GlobalLight; // global light
    //[SerializeField] private LightingPreset Preset;
    //[SerializeField, Range(0,24)] private float TimeOfDay;

    //private void UpdateLighting(float TimePercent)
    //{
    //    RenderSettings.ambientLight = Preset.AmbientColor.Evaluate(TimePercent);
    //    RenderSettings.fogColor = Preset.FogColor.Evaluate(TimePercent);

    //    if(GlobalLight != null)
    //    {
    //        GlobalLight.color = Preset.DiractionalColor.Evaluate(TimePercent);
    //        //GlobalLight.trans
    //    }
    //}
    //private void OnValidate()
    //{
    //    if (GlobalLight != null)
    //        return;
    //    if(RenderSettings.sun != null)
    //        GlobalLight = RenderSettings.sun;
    //    else
    //    {
    //        Light[] Lights = GameObject.FindObjectsOfType<Light>();
    //        foreach (Light light in Lights)
    //        {
    //            if(light.type == LightType.Directional) {
    //                GlobalLight = light;
    //                return;
    //            }
    //        }
    //    }
    //}
    //private void Update()
    //{
    //    if (Preset == null) return;

    //    if (GlobalLight != null) return;
    //    if(Application.isPlaying)
    //    {
    //        TimeOfDay += Time.deltaTime;
    //        TimeOfDay %= 24;
    //        UpdateLighting(TimeOfDay / 24f);
    //    }
    //    else 
    //        UpdateLighting(TimeOfDay / 24f);
    //    //if(GlobalLight.intensity >= 0.3f) GlobalLight.intensity = Mathf.PingPong(Time.time * DayInGame, 1f);
    //    //if (GlobalLight.intensity < 0.3f) GlobalLight.intensity = Mathf.Lerp(0.3f, 0.31f, NightInGame);
    //}

    //// method get intensity in real time
    //public float GetIntensity()
    //{
    //    return GlobalLight.intensity;
    //}
}
