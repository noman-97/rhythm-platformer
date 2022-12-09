using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audioData;

    
    void Start()
    {
        audioData = GetComponent<AudioSource>();
   
    }

    // Update is called once per frame
    


    public void startMusic()
    {
        audioData.time = 7.8f;
        audioData.Play();
    }
}
