using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour {
	//	GameObject orangeGoal;
	//	GameObject blueGoal;


	public Vector3 startPos;
	public Vector2 startVelocity;
	GameObject scoreManager; 
	ScoreManager sm; 
	Rigidbody2D rb;
	public bool canBeGrabbed = true;
	public bool grabbed = false;
	public float normalGrav;
	public float normalMass; 
	public float grabbedGrav;
	public float grabbedMass;
	public PhysicsMaterial2D blankPhysics; 
	public PhysicsMaterial2D bouncePhysics; 
	public int grabTimer;
	public int grabLimit;
	public bool dropped;
	public int physicsTimer;
	public int physicsLimit;


	// Use this for initialization
	void Start () {
		//		orangeGoal = GameObject.Find ("Orange Goal");
		//		blueGoal = GameObject.Find ("Blue Goal");
		rb = GetComponent<Rigidbody2D> ();
		scoreManager = GameObject.Find ("ScoreManager");
		sm = scoreManager.GetComponent<ScoreManager> ();
	}

	// Update is called once per frame
	void Update () {

		grabbedProperties ();
		ballDrop ();

	}

	void OnCollisionEnter2D(Collision2D touched)
	{
		if (touched.gameObject.tag == "Goal") 
		{
			transform.position = startPos;
			rb.velocity = startVelocity;

			if (touched.gameObject.name == "Blue Goal")
			{
				sm.blueGoal ();
			}

			if (touched.gameObject.name == "Orange Goal") 
			{
				sm.orangeGoal ();
			}
		}

	}

	void grabbedProperties ()
	{
		if (grabbed == true) 
		{
			rb.gravityScale = grabbedGrav;
			rb.mass = grabbedMass;
			rb.sharedMaterial = blankPhysics;
		}

		if (grabbed == false)
		{
			rb.gravityScale = normalGrav;
			rb.mass = normalMass;
//			rb.sharedMaterial = bouncePhysics;
		}
	}

	void ballDrop()
	{
		if (grabbed == true) 
		{
			grabTimer++;
		}

		if (grabTimer >= grabLimit) 
		{
			grabbed = false;
			canBeGrabbed = true;
			grabTimer = 0;
			rb.velocity = new Vector2 (0, 0);
			dropped = true;
		}

		if (dropped == true) 
		{
			rb.sharedMaterial = blankPhysics;
			physicsTimer++;
		}

		if (physicsTimer >= physicsLimit) 
		{
			dropped = false; 
			physicsTimer = 0;
			rb.sharedMaterial = bouncePhysics; 
		}
	}

}