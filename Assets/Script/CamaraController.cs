using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public float speedH, speedV;
    public float movimientoX,movimientoY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoX += Input.GetAxis("Mouse X") * speedH;
        movimientoY -= Input.GetAxis("Mouse Y") * speedV;

        
        transform.eulerAngles = new Vector3(movimientoY, movimientoX, 0f);
    }
}
