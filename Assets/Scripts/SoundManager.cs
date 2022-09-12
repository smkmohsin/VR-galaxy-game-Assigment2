using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip onClick, onHover, onStart;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        InvokeRepeating("GameStart", 1, 60.6f);
    }

    // Update is called once per frame
    void Update()
    {
        //audioSource.PlayOneShot(onStart);
    }

    public void Hover()
    {
        audioSource.PlayOneShot(onHover);
    }

    public void OnClick()
    {
        audioSource.PlayOneShot(onClick);
    }

    public void GameStart()
    {
        audioSource.PlayOneShot(onStart);
    }
}
