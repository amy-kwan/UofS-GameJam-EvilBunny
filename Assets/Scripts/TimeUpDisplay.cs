using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TimeUpDisplay : MonoBehaviour {


    Text text;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

        text.text = "";

    }
	
	// Update is called once per frame
	void Update () {
	


	}

    public void TimeUp()
    {
        text.text = "Time Up!";
    }
}
