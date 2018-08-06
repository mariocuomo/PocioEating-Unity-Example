using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaManager : MonoBehaviour {
    public GameObject prefabBomba;
    float timer;

    // Use this for initialization
    void Start () {
        timer = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameObject bomba = Instantiate(prefabBomba, GameObject.Find("Canvas").transform);
            if (GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte<20)
                if (Random.Range(0, 9) != 5)
                    Destroy(bomba);
            if (GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte >= 20 && GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte < 30)
                if (Random.Range(1, 8) != 5)
                    Destroy(bomba);
            if (GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte >= 30 && GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte < 40)
                if (Random.Range(1, 7) != 5)
                    Destroy(bomba);
            if (GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte >= 40 && GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte < 50)
                if (Random.Range(1, 6) != 5)
                    Destroy(bomba);
            if (GameObject.Find("Pocio").GetComponent<pocioManager>().gemmeRaccolte >= 50)
                if (Random.Range(2, 6) != 5)
                    Destroy(bomba);

            bomba.name = "Bomba";
            bomba.transform.localPosition = new Vector3(Random.Range(-650, 650), prefabBomba.transform.localPosition.y, prefabBomba.transform.localPosition.z);
            timer = 2f;
        }


    }
}
