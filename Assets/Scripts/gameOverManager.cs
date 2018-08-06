using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOverManager : MonoBehaviour {
    float timer;
    public GameObject score;
    public GameObject play;
    public GameObject back;
    public Sprite img;

    // Use this for initialization
    void Start () {
        timer = 3f;	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            if (GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte >= PlayerPrefs.GetInt("Record"))
                PlayerPrefs.SetInt("Record", GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte);

            this.GetComponent<Image>().sprite = img;
            score.SetActive(true);
            play.SetActive(true);
            back.SetActive(true);
        }

        if (GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte == PlayerPrefs.GetInt("Record"))
            score.GetComponent<Text>().text = "NEW RECORD!!\n" + GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte.ToString();
        else
            score.GetComponent<Text>().text = "YOUR SCORE IS\n" + GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte.ToString();
    }

    public void Play()
    {
        SceneManager.LoadScene("Gioco");
    }

    public void Back()
    {
        SceneManager.LoadScene("MenuPrincipale");
    }
}
