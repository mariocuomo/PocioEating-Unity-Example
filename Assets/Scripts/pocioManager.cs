using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pocioManager : MonoBehaviour {
    float speed;
    Rigidbody2D rb;
    float h;
    public int gemmeRaccolte;
    public GameObject GameOver;
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        speed = 100;
        gemmeRaccolte = 0;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed*Input.acceleration.x, 0, 0);
        GameObject.Find("numeroGemme").GetComponent<Text>().text = gemmeRaccolte.ToString();
        h = Input.GetAxis("Horizontal");

        Vector3 tempVect = new Vector3(h, 0, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);

        if (this.transform.localPosition.x < -650)
            this.transform.localPosition = new Vector3(640, this.transform.localPosition.y, this.transform.localPosition.z);
        if (this.transform.localPosition.x > 650)
            this.transform.localPosition = new Vector3(-640, this.transform.localPosition.y, this.transform.localPosition.z);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Gemma")
        {
            Destroy(coll.gameObject);
            gemmeRaccolte++;
        }

        if (coll.gameObject.name == "Bomba")
        {
            Destroy(coll.gameObject);
            GameObject.Find("EventSystem").GetComponent<gemmeManager>().enabled=false;
            GameObject.Find("EventSystem").GetComponent<bombaManager>().enabled = false;
            GameOver.SetActive(true);
        }
    }
}
