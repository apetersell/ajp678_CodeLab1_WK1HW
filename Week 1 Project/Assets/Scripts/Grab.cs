using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {

	SpriteRenderer sr;
	BoxCollider2D bc;
	GameObject ball;
	BallReset br;
	public Collider2D ballCollider;  
	public Vector3 leftPos;
	public Vector3 rightPos; 
	public bool facingRight;
	public KeyCode right; 
	public KeyCode left;  
	public KeyCode grab; 
	public Color empty;
	public Color inRange; 
	public bool canGrab;
	public float heightAboveHead;
	public GameObject player; 


	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> (); 
		ball = GameObject.Find ("Ball");
		br = ball.GetComponent<BallReset> ();
		bc = GetComponent<BoxCollider2D> ();
		
	}

	// Update is called once per frame
	void Update () {
		boxJustify ();
		grabAction (ballCollider); 
		ballHold ();


	
	}

	void boxJustify()
	{ 
		if (Input.GetKeyDown (right)) 
		{
			facingRight = true;
		}

		if (Input.GetKeyDown (left)) 
		{
			facingRight = false; 
		}

		if (facingRight == true) 
		{
			transform.localPosition = rightPos;
		}

		if (facingRight == false) 
		{
			transform.localPosition = leftPos; 
		}
	}

	void grabAction(Collider2D col)
	{
		if (bc.IsTouching(col) && br.canBeGrabbed == true)
		{
			sr.color = inRange; 
			canGrab = true; 
		}
		if (!bc.IsTouching(col))
		{
			sr.color = empty; 
			canGrab = false; 
		}
	}

	void ballHold()
	{
		if (canGrab == true && br.canBeGrabbed == true)
		{
			if (Input.GetKeyDown (grab)) 
			{
				br.grabbed = true;
				br.canBeGrabbed = false;
			}
		}
		if (br.grabbed == true) 
		{
			ball.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + heightAboveHead, player.transform.position.z);
		}
	}
}