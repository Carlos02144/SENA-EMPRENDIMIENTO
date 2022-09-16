using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaController : MonoBehaviour
{
    public static PuertaController Instance{ get; private set; }
    public Animator animator;
    public float currentTime;
    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
    
        animator.enabled = false;
    }
    private void Update()
    {
        if(animator.enabled == true)
        {
            currentTime += Time.deltaTime;
        }
        if(currentTime >= 6.0)
        {
            currentTime = 0;
            animator.Play("Close");

        }
    }
    public void StartAnimation()
    {
        animator.enabled = true;
    }
    

}
