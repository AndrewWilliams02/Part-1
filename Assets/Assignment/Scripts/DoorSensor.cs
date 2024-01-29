using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSensor : MonoBehaviour
{

    public GameObject metalDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (metalDoor.activeInHierarchy)
        {
            metalDoor.SetActive(false); 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!metalDoor.activeInHierarchy)
        {
            metalDoor.SetActive(true);
        }
    }
}
