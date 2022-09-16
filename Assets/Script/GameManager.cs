using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleCollsion();
    }
    void HandleCollsion()
    {
        if (BotonController.Instance.collision)
        { 
            if(Input.GetKeyDown("e"))
            {
                PuertaController.Instance.StartAnimation();
            }
            print("Collision");
        }
    }
}
