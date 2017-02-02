using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {

	SpriteRenderer psr;
	public Vector3 leftPos;
	public Vector3 rightPos; 
	public bool facingRight;
	public KeyCode right; 
	public KeyCode left; 


	// Use this for initialization
	void Start () {
		psr = GetComponentInParent<SpriteRenderer> (); 
		
	}

	// Update is called once per frame
	void Update () {
		boxJustify ();
	
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
		
}