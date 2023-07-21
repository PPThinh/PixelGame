using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "lighting Preset", menuName = "Scripttables/Lighting Preset", order = 1)]


// tai lieu ScriptableObject https://thoxaylamcoder.wordpress.com/2016/05/01/unity3d-su-dung-scriptableobject-de-luu-cac-thong-so-cau-hinh-trong-game/
public class LightingPreset : ScriptableObject
{
    public Gradient AmbientColor; // mau xung quanh map
    public Gradient DiractionalColor; // mau duoc chi dinh
    public Gradient FogColor; // mau suong mu
}