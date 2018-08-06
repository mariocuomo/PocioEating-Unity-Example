using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class caricamentoManager : MonoBehaviour {
    float timer;
    float timerTutorial;
    public GameObject tutorial;
    public Text descrizione;

	// Use this for initialization
	void Start () {
        GameObject.Find("Scrollbar").GetComponent<Scrollbar>().size = 0;
        timer = 3f;
        timerTutorial = 0f;
    }

    // Update is called once per frame
    void Update () {
        if (PlayerPrefs.GetInt("tutorial")==0)
            PlayerPrefs.SetInt("tutorial", PlayerPrefs.GetInt("tutorial")+1);
        if(PlayerPrefs.GetInt("tutorial") == 1)
        {
            timerTutorial += Time.deltaTime;
            tutorial.SetActive(true);
            if (timerTutorial <= 2.5)
                descrizione.text = "YOU ARE A LOVER OF GEMS. COLLECT AS MANY AS YOU CAN";
            if (timerTutorial > 2.5 && timerTutorial<=5.5)
                descrizione.text = "THESE ARE ALL YOUR GEMS";
            if (timerTutorial > 5.5 && timerTutorial <= 8.5)
                descrizione.text = "BUT PAY ATTENTION TO THESE OBJECTS, YOU COULD LOSE ANYTHING!";
            if (timerTutorial > 8.5 && timerTutorial <= 15)
                descrizione.text = "LET'S GO POCIO!\n YOU CAN MOVE IT ORIENTING YOUR DEVICE";
            if (timerTutorial > 15)
            {
                tutorial.SetActive(false);
                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    GameObject.Find("Scrollbar").GetComponent<Scrollbar>().size = 1 - timer / 3;
                }
                else
                {
                    PlayerPrefs.SetInt("tutorial", PlayerPrefs.GetInt("tutorial") + 1);
                    SceneManager.LoadScene("Gioco");
                }
            }

        }

        if (PlayerPrefs.GetInt("tutorial") >= 2)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                GameObject.Find("Scrollbar").GetComponent<Scrollbar>().size = 1 - timer / 3;
            }
            else
            {
                PlayerPrefs.SetInt("tutorial", PlayerPrefs.GetInt("tutorial") + 1);
                SceneManager.LoadScene("Gioco");
            }
        }


    }
}
