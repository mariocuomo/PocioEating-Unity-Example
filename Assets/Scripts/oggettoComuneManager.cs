using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oggettoComuneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
     
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
