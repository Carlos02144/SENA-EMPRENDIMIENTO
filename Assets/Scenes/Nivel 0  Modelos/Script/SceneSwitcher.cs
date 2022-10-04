using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
