using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaController : MonoBehaviour
{

    private void Update()
    {
        if(BotonController.Instance.videoEnd == true)
        {
            print("no");     
            Destroy(gameObject);
        }   
    }

}
