using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashScreenManager : MonoBehaviour {
    float timer;
	// Use this for initialization
	void Start () {
        timer = 3f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
            SceneManager.LoadScene("MenuPrincipale");
	}
}
