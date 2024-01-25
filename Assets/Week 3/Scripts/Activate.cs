using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameObject wall;
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
        if (wall.activeInHierarchy)
        {
            wall.SetActive(false);
        }
        else
        {
            wall.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }

}
