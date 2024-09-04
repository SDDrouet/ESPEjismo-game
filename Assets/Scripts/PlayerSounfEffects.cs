using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounfEffects : MonoBehaviour
{
    public AudioSource audioSource;
    public bool isWalking = false;

    // Update is called once per frame
    void Update()
    {
        if (isWalking)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }


        //capture the input
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
    }
}
