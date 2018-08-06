using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gemmeManager : MonoBehaviour {
    float timer;
    float nuovoTimer;
    public GameObject prefabGemma;
    public Sprite[] gemme;
	// Use this for initialization
	void Start () {
        timer = 5f;
        nuovoTimer = 3f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            GameObject gemma = Instantiate(prefabGemma,GameObject.Find("Canvas").transform);
            gemma.name = "Gemma";
            gemma.transform.localPosition = new Vector3(Random.Range(-650,650), prefabGemma.transform.localPosition.y, prefabGemma.transform.localPosition.z);
            gemma.GetComponent<Image>().sprite = gemme[Random.Range(0, 9)];
            if(nuovoTimer >=1)
                nuovoTimer -= Time.deltaTime;
            timer = nuovoTimer;
        }

    }
}
