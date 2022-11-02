using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BotonController : MonoBehaviour
{
    public static BotonController Instance { get; private set; }
    public bool collision;
    public VideoPlayer videoPlayer;
    public Animator PuertaAnimation;
    public string animationToPlay = "";
    public bool onPlay;
    public bool videoEnd;
   
    void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (videoPlayer.isPlaying)
        {
            onPlay = true;
        }
        else onPlay = false;
        
        if(collision && !onPlay && Input.GetKeyDown(KeyCode.E))
        {
            if (animationToPlay == "")
            {

            }
            else PlayAnimation(animationToPlay);
            videoPlayer.Pause();
            videoEnd = true;
        }
    }
    // Update is called once per frame
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            collision = true;
            if (!videoPlayer.isPaused)
            {
                videoPlayer.Play();
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {
            collision = false;
    }
    void PlayAnimation(string name)
    {
        PuertaAnimation.Play(name);
    }
}
