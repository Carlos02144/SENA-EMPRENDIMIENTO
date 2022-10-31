using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    public Transform Target;
    public GameObject ThePlayer;
    public GameObject Nivel0;

    private void OnTriggerEnter(Collider other)
    {
        ThePlayer.transform.position = Target.transform.position;

        if (transform.position.y >= -42.25745f)
        {
            Destroy(this.Nivel0);
        }

    }

    
}
