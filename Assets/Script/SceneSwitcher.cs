using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public bool start;
    public string nameScene;
    public static SceneSwitcher Instance { get; set; }
    void Awake()
    {
        Instance = this;
    }
    public void StartScene()
    {
        SceneManager.LoadScene(nameScene);
        start = false;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
