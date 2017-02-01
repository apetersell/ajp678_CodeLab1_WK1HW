using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour {
	//	GameObject orangeGoal;
	//	GameObject blueGoal;
	Rigidbody2D rb;

	public Vector3 startPos;
	public Vector2 startVelocity;
	GameObject scoreManager; 
	ScoreManager sm; 
//	public bool grabbed = false;
////public float normalGrav;
////public float normalMass; 
//	public PhysicsMaterial2D blankPhysics; 
//	public PhysicsMaterial2D bouncePhysics; 
//
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

		//grabbedProperties ();

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

//	void grabbedProperties ()
//	{
//		if (grabbed == true) 
//		{
//			rb.gravityScale = 0;
//			rb.mass = 0;
//			rb.sharedMaterial = blankPhysics;
//		}
//
//		if (grabbed == false)
//		{
//			rb.gravityScale = normalGrav;
//			rb.mass = normalMass;
//			rb.sharedMaterial = bouncePhysics;
//		}
//	}

}