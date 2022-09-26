using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class objetivosController : MonoBehaviour
{
    public static objetivosController Instance { get; private set; }
    public int numObjetivos;


    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            numObjetivos--;
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
