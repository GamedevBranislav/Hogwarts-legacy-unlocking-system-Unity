using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;
    private float lastPlayedTime;
    public float pitchMultiplier = 1f;
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        
       
    }

    void Update()
    {
        //will play sound when any of these keys are pressed and in random pitch value 0,8 to 1.2
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
        {
            if (Time.time - lastPlayedTime >= 1f)
            {
                audioSource.pitch = Random.Range(0.8f, 1.2f) * pitchMultiplier; // Set pitch to a random value between 0.8 and 1.2 times pitchMultiplier
                audioSource.Play();
                lastPlayedTime = Time.time;
            }
        }
    }
}
