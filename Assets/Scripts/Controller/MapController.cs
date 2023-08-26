using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Transform schoolPoint;
    public Transform campingPoint;
    public Transform condoPoint;
    public Transform supperMarketPoint;

    public Transform playerPosition;
    private void FixedUpdate()
    {

        //button1.onClick.AddListener();K
        

        if(Input.GetButton("Condo"))
        {
            playerPosition.position = condoPoint.position;
        }

        if(Input.GetButton("Camping"))
        {
            playerPosition.position = campingPoint.position;
        }

        if(Input.GetButton("SupperMarket"))
        {
            playerPosition.position = supperMarketPoint.position;
        }
    }

    void SpawnPoint()
    {
        //playerPosition.position = condoPoint.po
    }
}
