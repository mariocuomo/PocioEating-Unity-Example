using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipaleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        SceneManager.LoadScene("CaricamentoGioco");
    }

    public void Option()
    {
        SceneManager.LoadScene("Opzioni");
    }

    public void Back()
    {
        Application.Quit();
    }
}
