using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public bool start,collision;
    public string nameScene;
    public static SceneSwitcher Instance { get; set; }
    void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && collision == true)
        {
            Debug.Log("E");
            StartScene();
        }
    }
    public void StartScene()
    {
        SceneManager.LoadScene(nameScene);
        start = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collision = true;
           
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
