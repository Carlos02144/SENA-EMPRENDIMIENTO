using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;
public class MisionController : MonoBehaviour
{
    public float tiempoCorrido;
    public bool completado;
    public TextMeshProUGUI textoRecuentoDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject panelBotones;
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
            textoRecuentoDeObjetivos.text = "Completaste la Mision!";
            if(tiempoCorrido>=4)
            {
                canvas.enabled = false;
            }
        }else{ textoRecuentoDeObjetivos.text = $"Obejtivos restantes: {numObjetivos}"; }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            panelBotones.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            panelBotones.SetActive(false);
        }
    }
}
