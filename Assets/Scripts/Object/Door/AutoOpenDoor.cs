using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// collider auto door
public class AutoOpenDoor : MonoBehaviour
{
    [SerializeField] public GameObject DoorObject;
    private IDoor Door;
    private void Awake()
    {
        Door = DoorObject.GetComponent<IDoor>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && collider != null)
        {
            Door.OpenDoor();
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
           if (collider.tag == "Player" && collider != null)
               Door.CloseDoor();
    }
}
