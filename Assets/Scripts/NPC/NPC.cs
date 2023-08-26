using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

[CreateAssetMenu(fileName = "New NPC", menuName = "NPC")]
public class NPC : ScriptableObject
{
    [SerializeField] private string npcName;
    //[SerializeField] private TMP_Text text;
    [SerializeField] private Animator animator;
    [SerializeField] private Animation animation;
    private Transform npcDiration;

    

    

}
