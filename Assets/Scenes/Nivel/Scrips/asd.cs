using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    public Transform Target;
    public GameObject ThePlayer;
    public GameObject Nivel1;

    private void OnTriggerEnter(Collider other)
    {
        ThePlayer.transform.position = Target.transform.position;

        if (transform.position.y >= -5.53)
        {

        }

    }
}
