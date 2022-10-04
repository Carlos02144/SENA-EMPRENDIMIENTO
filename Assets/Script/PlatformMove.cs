using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public GameObject[] wayTarget;
    public float speed = 2;

    public int targetIndex = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlataform();    
    }
    void MovePlataform()
    {
        if (Vector3.Distance(transform.position, wayTarget[targetIndex].transform.position) < 0.5f)
        {
            targetIndex++;
            if(targetIndex>=wayTarget.Length)
            {
                targetIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position,wayTarget[targetIndex].transform.position,speed*Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.SetParent(transform);
    }
    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}
