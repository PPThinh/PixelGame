using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IDoor
{
    // input object use animation
    [SerializeField] private Animator animator;
    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // method to open and close the door
    public void OpenDoor()
    {
        animator.SetBool("Open", true);
    }

    public void CloseDoor()
    {
        animator.SetBool("Open", false);

    }
}
