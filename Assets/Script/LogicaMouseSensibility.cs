using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaMouseSensibility : MonoBehaviour
{
    public float sliderValue;
    public Slider slider;

    public static LogicaMouseSensibility Instance { get; private set; }
    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("mouseSensibility", 60);
        sliderValue = slider.value;
    }
    // Update is called once per frame
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        slider.value = PlayerPrefs.GetFloat("mouseSensibility", sliderValue);
    }
}
