using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    public Slider slider;
    public AudioSource myMusic;

    public void Start()
    {
        myMusic = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
        myMusic.volume = PlayerPrefs.GetFloat("volume");
    }

    //Turns Music up/down
    public void Update()
    {
        myMusic.volume = slider.value;
        PlayerPrefs.SetFloat("volume", myMusic.volume);
    }

    //Toggles music on/off
    public void ToggleSound()
    {
        myMusic.mute = !myMusic.mute;

    }
}