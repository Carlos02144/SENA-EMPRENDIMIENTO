using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float currentTime;
    bool open =false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameState();
    }
    void GameState()
    {
        if (open)
        {
            currentTime += Time.deltaTime;
            if(currentTime >6)
            {
                //PuertaController.Instance.setAnimation("Close");
                currentTime = 0;
                open = false;
            }
        }
    }
}

