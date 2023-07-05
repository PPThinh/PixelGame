using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// chuyen dong cua door
public class DoorAnimated : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetBool("Open", true);
    }

    public void CloseDoor()
    {
        animator.SetBool("Open", false);

    }
}
