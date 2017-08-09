using UnityEngine;
using System.Collections;



public class Knight_Trigger : MonoBehaviour {


    public int pointsToAdd;
    private SpriteRenderer movieScreen;
    public GameObject Sound;
    public int distance;
    public bool upDownDirection;
    public float travelled = 0;
    float direction = 0.1f;

	// Use this for initialization
	void Start () {
        movieScreen = GameObject.Find("MovieScreen").GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Move the knight.
    void FixedUpdate()
    {        
        if (travelled >= distance)
        {
            direction = -direction;
        }
        else if (travelled <= -distance)
        {
            direction = -direction;
        }

        if (upDownDirection)
        {
            this.gameObject.transform.position += new Vector3(0, direction, 0);
        }
        else
        {
            this.gameObject.transform.position += new Vector3(direction, 0, 0);
        }

        travelled += direction;

       float deltaX = (this.gameObject.transform.position.x - GameObject.Find("Bunny").transform.position.x);
       float delatY = (this.gameObject.transform.position.y - GameObject.Find("Bunny").transform.position.y);
       float characterDistance = Mathf.Sqrt(Mathf.Pow(deltaX, 2) + Mathf.Pow(delatY, 2));
       this.gameObject.GetComponent<AudioSource>().volume = 1 / characterDistance;
    }
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Bunny")
        {
            Destroy(gameObject);
            movieScreen.gameObject.GetComponent<Animator>().SetBool("isPlaying", true);
            movieScreen.enabled = true;
            ScoreManager.AddPoints(pointsToAdd);
            Sound.GetComponent<AudioSource>().Play();

          //Invoke("die", 5.0f);
          
        }
    }



    void die()
    {
        Destroy(gameObject);

    }
}
