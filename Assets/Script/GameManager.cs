using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;
using Newtonsoft.Json;

public enum GameState { Ready, Playing, Finish, Pause};
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameState gameState = GameState.Playing;
    public static GameManager Instance { get; private set; }
    public GameObject menuPausa;
    public bool escape, onConfig;

    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Escape) && escape == false && onConfig==false)
        {
            menuPausa.SetActive(true);
            gameState = GameState.Pause;
            escape = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && gameState == GameState.Pause && escape == true && onConfig==false)
        {
            menuPausa.SetActive(false);
            gameState=GameState.Playing;
            escape = false;
            onConfig = false;
        }
    }
    public void OnConfig(bool On)
    {
        onConfig = On;
    }
}

