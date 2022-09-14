using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonController : MonoBehaviour
{
    public static BotonController Instance { get; private set; }
    public bool collision;
   
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            collision = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
            collision = false;
    }
}
