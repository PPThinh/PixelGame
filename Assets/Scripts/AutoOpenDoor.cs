using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// cua tu dong
public class AutoOpenDoor : MonoBehaviour
{
     [SerializeField] private DoorAnimated door;

     private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player" && collider != null)
        {
            door.OpenDoor();
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.tag == "Player" && collider != null)
            door.CloseDoor();
    }
}
