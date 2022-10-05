using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;

public enum GameState { Ready, Playing, Finish};
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameState gameState = GameState.Ready;
    public float currentTime;
    bool open =false;
    bool action;

    void Start()
    {
        action = Input.GetMouseButtonDown(0);
    }

    // Update is called once per frame
    void Update()
    {
        GameStateUpdate();
    }
    void GameStateUpdate()
    {
        if (gameState == GameState.Ready && action) gameState = GameState.Playing;
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

