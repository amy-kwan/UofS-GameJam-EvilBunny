using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplayer : MonoBehaviour {
    public TimeUpDisplay Timer;

    Text text;
    public int totalTime;
    int count = 0;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

        text.text = "" + totalTime;

    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("MovieScreen").GetComponent<Animator>().GetBool("isPlaying"))
        {
            return;
        }

        count += 1;
        if (count == 60)
        {
            if (totalTime > 0)
            {
                totalTime -= 1;
                count = 0;
                text.text = "" + totalTime;
            }
            if(totalTime == 0)
            {
                Timer.TimeUp();
            }
        }
    }


}

