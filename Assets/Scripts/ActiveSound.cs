using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSound : MonoBehaviour {


    AudioSource audioSource;
    private bool paused;
    private bool playing;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        paused = true;
        playing = false;
    }

    private float contactTime = 0;

    private void OnTriggerEnter(Collider other)
    {
        PlaySound();
    }

    void PlaySound()
    {
        playing = audioSource.isPlaying;
        if (paused == true && playing == false)
        {
            Debug.Log("Play");
            audioSource.Play(0);
            paused = false;
        }

        else if (paused == false)
        {
            Debug.Log("Pause");
            audioSource.Pause();
            paused = true;
        }

        else if (paused == true)
        {
            Debug.Log("UnPause");
            audioSource.UnPause();
            paused = false;
        }

    }
}
