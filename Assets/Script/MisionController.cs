using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;
public class MisionController : MonoBehaviour
{
    public bool onArea,accion, aceptarMision,completado;
    public CharacterControler player;
    public GameObject panelInteraccion, descripcionMision, recuentoObjetos;
    public TextMeshProUGUI textoRecuento;
    public GameObject[] objetosRecoger;
    public float currentTime;
    public int numeroObjetos;
    public GameObject objetivo;
    void Start()
    {
        numeroObjetos = objetosRecoger.Length;
        textoRecuento.text = $"El numero de Objetos faltantes son: {numeroObjetos}";
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterControler>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Acciones de Interracion <>
        if (Input.GetKeyDown("e") && onArea && player.PuedoSaltar == true)
        {
            Vector3 lookTarget = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            player.gameObject.transform.LookAt(lookTarget);
            panelInteraccion.SetActive(false);
            descripcionMision.SetActive(true);
            accion = true;

            player.enabled = false;
        }
        //</>
        if (numeroObjetos <= 0) completado = true;
        if(completado)
        {
            
            textoRecuento.text = "Haz Completado con Exito la Mision!";
            if (currentTime < 4)
            {
                currentTime += Time.deltaTime;
                recuentoObjetos.SetActive(true);

            }
            else recuentoObjetos.SetActive(false);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !completado)
        {
            onArea = true;
            if (!accion) panelInteraccion.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            onArea = false;
            if (!accion) panelInteraccion.SetActive(false);
        }
    }
    public void No()
    { 
        player.enabled = true;
        accion = false;
        descripcionMision.SetActive(false);
        panelInteraccion.SetActive(true);
    }
    public void Si()
    {
        aceptarMision = true;
       
        onArea = false;
        recuentoObjetos.SetActive(true);

    }
}
