using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;
public class MisionController : MonoBehaviour
{
    public bool onArea, accion, aceptarMision, completado;
    public GameObject[] objetosRecoger;
    public float currentTime;
    public int numeroObjetos;
    void Start()
    {
        numeroObjetos = objetosRecoger.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (numeroObjetos <= 0) completado = true;
        if(completado)
        {
        
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !completado)
        {
            onArea = true;
        }
    }
}
