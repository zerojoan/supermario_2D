using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip goombaDeath;

    public AudioClip marioDeath;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSourece>();
    }

    public void GoombaDeath() 
    {
        source.PlayOneShot(goombaDeath);
    }

     public void MarioDeath() 
    {
        source.PlayOneShot(marioDeath);
    }
}
