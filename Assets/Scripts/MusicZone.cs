using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicZone : MonoBehaviour
{
    private AudioSource audiosource;
    public float fadeTime;
    public float maxVolume;
    private float targetVolume;

    void Start()
    {
        targetVolume = 0f;
        audiosource = GetComponent<AudioSource>();
        audiosource.volume = targetVolume;
        audiosource.Play();
    }

    void Update()
    {
        if (!Mathf.Approximately(audiosource.volume, targetVolume))
        {
            audiosource.volume = Mathf.MoveTowards(audiosource.volume, targetVolume, (maxVolume/fadeTime) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            targetVolume = maxVolume;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetVolume = 0f;
        }
    }
}
