using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class MisionController : MonoBehaviour
{
    public float tiempoCorrido;
    public bool completado;
    public TextMeshProUGUI textoMision;
    public Canvas canvas;
    public int numObjetivos =1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numObjetivos = GameObject.FindGameObjectsWithTag("Objetivos").Length;
        if (numObjetivos == 0)
        {
            completado = true;
        }
        if(completado)
        {
            tiempoCorrido += Time.deltaTime;
            textoMision.text = "Completaste la Mision!";
            if(tiempoCorrido>=4)
            {
                canvas.enabled = false;
            }
        }else{ textoMision.text = $"Obejtivos restantes: {numObjetivos}"; }
    }
}
