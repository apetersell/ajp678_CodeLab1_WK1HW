using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {

	SpriteRenderer sr;
	BoxCollider2D bc;
	GameObject ball;
	BallReset br;
	PlayerMovement pm;
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
	public GameObject playerGuy;
	public GameObject playerGal;
	public int playerNumber;


	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> (); 
		ball = GameObject.Find ("Ball");
		br = ball.GetComponent<BallReset> ();
		bc = GetComponent<BoxCollider2D> ();
		pm = GetComponentInParent<PlayerMovement> (); 
		
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
		if (bc.IsTouching(col) && br.canBeGrabbed == true && pm.dropStun == false)
		{
			sr.color = inRange; 
			canGrab = true; 
			if (playerNumber == 1) 
			{
				br.inHandsOfGuy = true;
			}
			if (playerNumber == 2) 
			{
				br.inHandsOfGal = true;
			}
		}
		if (!bc.IsTouching(col))
		{
			sr.color = empty; 
			canGrab = false; 
			if (playerNumber == 1) 
			{
				br.inHandsOfGuy = false;
			}
			if (playerNumber == 2) 
			{
				br.inHandsOfGal = false;
			}
		}
	}

	void ballHold()
	{
		if (canGrab == true && br.canBeGrabbed == true)
		{
			if (Input.GetKeyDown (grab) && br.inHandsOfGal == true) 
			{
				br.grabbed = true;
				br.grabbedByGal = true;
				br.canBeGrabbed = false;
			}

			if (Input.GetKeyDown (grab) && br.inHandsOfGuy == true) 
			{
				br.grabbed = true;
				br.grabbedByGuy = true;
				br.canBeGrabbed = false;
			}
		}
		if (br.grabbedByGal == true) 
		{
			ball.transform.position = new Vector3 (playerGal.transform.position.x, playerGal.transform.position.y + heightAboveHead, playerGal.transform.position.z);
		}

		if (br.grabbedByGuy == true) 
		{
			ball.transform.position = new Vector3 (playerGuy.transform.position.x, playerGuy.transform.position.y + heightAboveHead, playerGuy.transform.position.z);
		}
	}
}