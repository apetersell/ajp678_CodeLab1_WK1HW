using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {
	 
//	GameObject ball; 
//	public KeyCode grab;
//	public GameObject player;
//	public Vector3 holdPos; 
//	public bool hasTheBall; 
//	public bool canGrab;
//	public bool threwTheBall; 
//	public float grabTimer;
//	public float grabLimit; 
//	public float heightAboveHead;
//	public float throwForce; 
//	BallReset br;
//	Rigidbody2D ballrb;  
//	SpriteRenderer playersr; 
//
//	// Use this for initialization
//	void Start () {
//		
//		ball = GameObject.Find ("Ball"); 
//		br = ball.GetComponent<BallReset> ();
//		ballrb = ball.GetComponent<Rigidbody2D> ();
//		playersr = player.GetComponent<SpriteRenderer> ();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//
//		holdPos.x = player.transform.position.x;
//		holdPos.y = player.transform.position.y + heightAboveHead;
//		holdPos.z = player.transform.position.z;  
//		ballCarry ();
//		ballFire ();
//
//
//		
//	}
//
//	void OnTriggerEnter2D (Collider2D touched)
//	{
//		if (Input.GetKey (grab) && hasTheBall == false && touched.gameObject.name == "Ball") 
//		{
//			hasTheBall = true; 
//			br.grabbed = true; 
//			canGrab = false;
//
//		}
//	}
//
//	void ballCarry ()
//	{
//		if (hasTheBall == true)
//		{
//			br.transform.position = holdPos;
//		}
//	}
//
//	void ballFire ()
//	{
//		if (hasTheBall == true && Input.GetKeyDown (grab)) 
//		{
//			hasTheBall = false;
//			threwTheBall = true;
//
//			if (playersr.flipX == true) 
//			{
//				ballrb.AddForce (Vector2.right * throwForce);
//			}
//			if (playersr.flipX == false) 
//			{
//				ballrb.AddForce (Vector2.left * throwForce);
//			}
//
//		}
//
//		if (threwTheBall == true)
//		{
//			grabTimer++;
//		}
//
//		if (grabTimer >= grabLimit) 
//		{
//			threwTheBall = false;
//			grabTimer = 0; 
//			canGrab = true; 
//		}
//
//	}
}
