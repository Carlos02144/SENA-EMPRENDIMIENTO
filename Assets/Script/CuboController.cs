using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboController : MonoBehaviour
{
    public bool collision;

    public GameObject objectToMove;
    public Transform tranformMano;
    void Update()
    {
        if(collision)
        {
            if (Input.GetKeyDown(KeyCode.E)) // Si se Oprime E
            { 
                objectToMove.transform.SetParent(tranformMano);//El cubo se vovlera Hijo de la mano
                objectToMove.GetComponent<Collider>().enabled = false; //Dejara de tener el collider para que no empuje a nuestro personaje
                objectToMove.transform.position = tranformMano.position; // El transform del cubo sera igual que el de la mano
                objectToMove.GetComponent<Rigidbody>().isKinematic = true; //Se volvera KInematico para que no le afecten las fisicas en ese momento
            }
        }
        if(Input.GetKeyDown(KeyCode.G))//si se Oprime G
        {
            objectToMove.transform.SetParent(null);//dejara de ser hij@ de lo que sea
            objectToMove.GetComponent<Collider>().enabled = true;
            objectToMove.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            collision = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            collision = false;
        }
    }
}
