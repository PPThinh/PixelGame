using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UseCar : MonoBehaviour
{
    public Transform Car;
    public Transform Player;
    public MonoBehaviour CarController;
    //public GameObject useCar;
    public GameObject playerCam;
    public GameObject carCam;

    public Transform outCar;
    bool canDrive = false;
    bool isDriving = false;
    private BoxCollider2D boxCollider2D;

    Vector3 playerPos;
    private void Start()
    {
        playerPos = new Vector3 (0.5f, 0, 0);
        CarController.enabled = false;
        carCam.SetActive(false);
        boxCollider2D = GetComponent<BoxCollider2D>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canDrive)
        {
            CarController.enabled = true;
            Player.transform.SetParent(Car);
            Player.gameObject.SetActive(false);
            playerCam.SetActive(false);
            carCam.SetActive(true);
            isDriving = true;
            boxCollider2D.enabled = false;


        }
        if (Input.GetKeyDown(KeyCode.G) && isDriving)
        {
            //if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            //{
            Player.transform.SetParent(outCar.transform); // if player collider under car collider
            //}
            CarController.enabled = false;
            Player.gameObject.SetActive(true);
            playerCam.SetActive(true);
            carCam.SetActive(false);
            isDriving = false;
            boxCollider2D.enabled = true;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("is near");
            canDrive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("is not near");

            canDrive = false;
            //driveUI.gameObject.SetActive(false);
        }
    }

}
