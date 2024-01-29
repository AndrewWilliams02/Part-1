using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageDoorButton : MonoBehaviour
{
    public GameObject button;
    public GameObject cageDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        cageDoor.transform.Translate(Vector2.up * 3);
        button.SetActive(false);
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
