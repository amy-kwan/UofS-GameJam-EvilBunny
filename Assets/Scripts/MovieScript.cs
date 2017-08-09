using UnityEngine;
using System.Collections;

public class MovieScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void EndMovie() {
        GetComponent<Animator>().SetBool("isPlaying", false);
        GetComponent<SpriteRenderer>().enabled = false;

        Debug.Log("holla");

        GameObject.Find("Bunny").transform.position += new Vector3(0, 0, -1);
    }

    void StartMovie() {
        GetComponent<Animator>().SetBool("isPlaying", true);

        GameObject.Find("Bunny").transform.position += new Vector3(0, 0, 1);
    }
}
