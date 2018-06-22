using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    public Slider volume;
    public AudioSource myMusic;

    public void Start()
    {
        myMusic = GameObject.FindWithTag("Player").GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("volume"))
        {
            myMusic.volume = PlayerPrefs.GetFloat("volume");
        }
        volume.value = PlayerPrefs.GetFloat("volume");
    }

    //Turns Music up/down
    private void Update()
    {
        myMusic.volume = volume.value;
        PlayerPrefs.SetFloat("volume", myMusic.volume);
    }

    //Toggles music on/off
    private void ToggleSound()
    {
        myMusic.mute = !myMusic.mute;

        if (myMusic.mute)
        {
            volume.value = PlayerPrefs.GetFloat("volume", 0);
        }
        myMusic.volume = PlayerPrefs.GetFloat("volume");
    }
}