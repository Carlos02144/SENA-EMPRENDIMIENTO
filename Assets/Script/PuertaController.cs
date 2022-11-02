using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaController : MonoBehaviour
{
    public static PuertaController Instance{ get; private set; }
    public Animator animator;
    
    void Awake()
    {
        Instance = this;
    }
    public void setAnimation(string name)
    {
        animator.Play(name);
    }

}
