using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    private bool end = false;
    public GameObject Level;
    public GameObject Menu;
    public GameObject FloppyBlob;
    public GameObject GameOver;
    public GameObject FirstMenu;

    private void Start()
    {
        // Level.SetActive(false);
        // Menu.SetActive(true);
        // end = false;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase != TouchPhase.Began)
            {
                return;
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            OnTouch();
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        if (!end)
        {
            direction.y += gravity * Time.deltaTime;
            transform.position += direction * Time.deltaTime;
        }
    }

    private void OnTouch()
    {
        if (!end)
        {
            direction = Vector3.up * strength;   
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Wall")
        {
            Debug.Log("Triggered by Wall");
            end = true;
            FloppyBlob.SetActive(false);
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            direction.y = 0;
            Level.SetActive(false);
            Menu.SetActive(true);
            GameOver.SetActive(true);
        }
    }   

    public void StartButton()
    {
        Menu.SetActive(false);
        GameOver.SetActive(false);
        FloppyBlob.SetActive(true);
        Level.SetActive(true);
        end = false;
    } 

    public void EndFirstMenu()
    {
        FirstMenu.SetActive(false);
    }
}
