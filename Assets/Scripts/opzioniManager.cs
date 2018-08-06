using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class opzioniManager : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("qualitaVideo"));
        if (GameObject.Find("oggettoComune").GetComponent<AudioSource>().volume == 1)
            GameObject.Find("HighAudio").GetComponent<Image>().color = new Color(0, 255, 255, 255);
        if (GameObject.Find("oggettoComune").GetComponent<AudioSource>().volume == 0.6f)
            GameObject.Find("MediumAudio").GetComponent<Image>().color = new Color(0, 255, 255, 255);
        if (GameObject.Find("oggettoComune").GetComponent<AudioSource>().volume == 0.3f)
            GameObject.Find("LowAudio").GetComponent<Image>().color = new Color(0, 255, 255, 255);
    }

    // Update is called once per frame
    void Update () {

        if (QualitySettings.GetQualityLevel() == 0) {
            GameObject.Find("HighQuality").GetComponent<Image>().color = new Color(255, 255, 255, 255);
            GameObject.Find("MediumQuality").GetComponent<Image>().color = new Color(255, 255, 255, 255);
            GameObject.Find("LowQuality").GetComponent<Image>().color = new Color(0, 255, 255, 255);
        }
        if (QualitySettings.GetQualityLevel() == 1)
        {
            GameObject.Find("HighQuality").GetComponent<Image>().color = new Color(255, 255, 255, 255);
            GameObject.Find("MediumQuality").GetComponent<Image>().color = new Color(0, 255, 255, 255);
            GameObject.Find("LowQuality").GetComponent<Image>().color = new Color(255, 255, 255, 255);
        }

        if (QualitySettings.GetQualityLevel() == 2)
        {
            GameObject.Find("HighQuality").GetComponent<Image>().color = new Color(0, 255, 255, 255);
            GameObject.Find("MediumQuality").GetComponent<Image>().color = new Color(255, 255, 255, 255);
            GameObject.Find("LowQuality").GetComponent<Image>().color = new Color(255, 255, 255, 255);
        }
    }

    public void HighQuality()
    {
        QualitySettings.SetQualityLevel(2);
        PlayerPrefs.SetInt("qualitaVideo", 2);
    }

    public void MediumQuality()
    {
        QualitySettings.SetQualityLevel(1);
        PlayerPrefs.SetInt("qualitaVideo", 1);
    }

    public void LowQuality()
    {
        QualitySettings.SetQualityLevel(0);
        PlayerPrefs.SetInt("qualitaVideo", 0);
    }

    public void HighAudio()
    {
        GameObject.Find("oggettoComune").GetComponent<AudioSource>().volume = 1;
        GameObject.Find("HighAudio").GetComponent<Image>().color = new Color(0, 255, 255, 255);
        GameObject.Find("MediumAudio").GetComponent<Image>().color = new Color(255, 255, 255, 255);
        GameObject.Find("LowAudio").GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }

    public void MediumAudio()
    {
        GameObject.Find("oggettoComune").GetComponent<AudioSource>().volume = 0.6f;
        GameObject.Find("HighAudio").GetComponent<Image>().color = new Color(255, 255, 255, 255);
        GameObject.Find("MediumAudio").GetComponent<Image>().color = new Color(0, 255, 255, 255);
        GameObject.Find("LowAudio").GetComponent<Image>().color = new Color(255, 255, 255, 255);

    }

    public void LowAudio()
    {
        GameObject.Find("oggettoComune").GetComponent<AudioSource>().volume = 0.3f;
        GameObject.Find("HighAudio").GetComponent<Image>().color = new Color(255, 255, 255, 255);
        GameObject.Find("MediumAudio").GetComponent<Image>().color = new Color(255, 255, 255, 255);
        GameObject.Find("LowAudio").GetComponent<Image>().color = new Color(0, 255, 255, 255);
    }

    public void Back()
    {
        SceneManager.LoadScene("MenuPrincipale");
    }
}
