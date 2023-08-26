using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerInteract : MonoBehaviour
    {
        [SerializeField] private Transform point;
        [SerializeField] private float pointRadius = 0.2f;
        [SerializeField] private LayerMask interactableMask;

        private void Update()
        {
            if (Physics2D.OverlapCircle(point.position, pointRadius, interactableMask))
            {
                if (Input.GetKeyDown(KeyCode.E))
                    Debug.Log("interact");  
                
            }
        }
    }
