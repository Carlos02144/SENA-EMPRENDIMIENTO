
using UnityEngine;

public class CuboController : MonoBehaviour
{

    public GameObject cubo;
    public Transform mano;

    private bool activo;

    // Update is called once per frame
    void Update()
    {
        
        if(activo==true)
        {
            if(Input.GetKey(KeyCode.R))
            {
                cubo.transform.SetParent(mano);
                //cubo.transform.position = mano.position;
                cubo.GetComponent<Rigidbody>().isKinematic = true;
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            activo = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if(other.tag=="Personaje")
        {
            activo = false;
        }

    }

}
