using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class PlayerStat : ScriptableObject
{
    string pLayerName;
    int money;
    [SerializeField] private GameObject mainUI;
    [SerializeField] private TMPro.TextMeshPro nameTMP;

    public string SetPlayerName
    {
        set{
             nameTMP.text = pLayerName;
        }
    }

    //public int diamond
    //{
    //    get {
    //        diamond
    //    };
    //    set
    //    {

    //    }
    //}
    
}
