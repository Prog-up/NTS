using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public GameObject Level;
    public GameObject Menu;
    public GameObject FloppyBlob;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        Menu.SetActive(false);
        FloppyBlob.SetActive(true);
        Level.SetActive(true);
    }
}
