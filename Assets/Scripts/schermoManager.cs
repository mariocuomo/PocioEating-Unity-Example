using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class schermoManager : MonoBehaviour {
    GameObject audio;
    GameObject play;
    public Sprite musicOn;
    public Sprite musicOff;
    public Sprite gameOn;
    public Sprite gameOff;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Music()
    {
        if (GameObject.Find("oggettoComune").GetComponent<AudioSource>().enabled == false)
        {
            GameObject.Find("oggettoComune").GetComponent<AudioSource>().enabled = true;
            GameObject.Find("Audio").GetComponent<Image>().sprite = musicOn;
        }
        else
        {
            GameObject.Find("oggettoComune").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("Audio").GetComponent<Image>().sprite = musicOff;
        }
    }

    public void Play()
    {
        if (Time.timeScale == 1)
        {
            GameObject.Find("Play").GetComponent<Image>().sprite = gameOff;
            Time.timeScale = 0;
        }
        else 
        {
            GameObject.Find("Play").GetComponent<Image>().sprite = gameOn;
            Time.timeScale = 1;
        }
    }
}
