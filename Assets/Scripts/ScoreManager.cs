using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int Score;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        Score = 0;
    }

    void Update()
    {
        if (Score < 0)
            Score = 0;

        text.text = "" + Score;
    }

    public static void AddPoints (int pointsToAdd)
    {
        Score += pointsToAdd;
    }

    public static void Reset()
    {
        Score = 0;
    }
}
