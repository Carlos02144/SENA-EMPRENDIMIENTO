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
       //HandleCollsion();
        GameState();
    }
    void GameState()
    {
        if (open)
        {
            currentTime += Time.deltaTime;
            if(currentTime >6)
            {
                //POner la animacion de cerrar close set
                currentTime = 0;
                open = false;
            }
        }
    }
/*    void HandleCollsion()
    {
        //Colision contra un boton
        if (BotonController.Instance.collision)
        { 
            if(Input.GetKeyDown("e"))
            {
                //pOner la animacion abrir puerta set
                open = true;
            }
        }
    }*/
}
