using UnityEngine;
using System.Collections;

public class Bunny_Behavior : MonoBehaviour {

	public GameObject Bunny;
    public GameObject Light;
    Rigidbody2D rbody;
    public float Speed;
    private Animator anim;
    private Animator bunan;
    private int current;
  
	// Use this for initialization
	void Start () {
        //instead of drag and dropping the bird in Unity. Could write, bird= GameObject.Find("Bird") and it does the same thing

        rbody = Bunny.GetComponent<Rigidbody2D>();
        //get ani
        anim = GameObject.Find("MovieScreen").GetComponent<Animator>();
       
        bunan = this.GetComponent<Animator>();
        current = 0;
	}

  
	// Update is called once per frame. generally input
	void Update () {
        
        

    }
    //movement and physics calls
    void FixedUpdate() {

       if (anim.GetBool("isPlaying") == false){   //isNotPlaying

   
              var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        if (vertical == 0 && horizontal == 0)
        {
             bunan.SetInteger("Direction", current + 4);
        }

        if (vertical > 0)
        {
            bunan.SetInteger("Direction", 0);
            current = 0;
        }
        else if (vertical < 0)
        {
            bunan.SetInteger("Direction", 2);
            current = 2;
        }
        else if (horizontal > 0)
        {
            bunan.SetInteger("Direction", 1);
            current = 1;
        }
        else if (horizontal < 0)
        {
            bunan.SetInteger("Direction", 3);
            current = 3;
        }
   
            rbody.velocity =new Vector3(
                Input.GetAxis("Horizontal") * Speed,
                Input.GetAxis("Vertical") * Speed,
                0);
           

            if(rbody.velocity.x > 0) {
                Bunny.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
           
       }
       else { 

       rbody.velocity = new Vector3(
            0,
            0,
            0);
       }

    }


    


}
