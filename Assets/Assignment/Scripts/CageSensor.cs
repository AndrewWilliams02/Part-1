using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageSensor : MonoBehaviour
{
    public GameObject cageDoor;
    public GameObject stickman;
    public Transform stickmanSpawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        cageDoor.transform.Translate(Vector2.down * 3);
        Instantiate(stickman, stickmanSpawn.position, stickmanSpawn.rotation);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {

    }
}
