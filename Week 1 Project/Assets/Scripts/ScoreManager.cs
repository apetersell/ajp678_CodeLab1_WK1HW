using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement; 

public class ScoreManager : MonoBehaviour {

	public int blueScore;
	public int orangeScore;
	public Sprite blue0;
	public Sprite blue1;
	public Sprite blue2;
	public Sprite blue3;
	public Sprite blue4;
	public Sprite blue5;
	public Sprite blue6;
	public Sprite blue7;
	public Sprite blue8;
	public Sprite blue9;
	public Sprite blue10;
	public Sprite orange0;
	public Sprite orange1;
	public Sprite orange2;
	public Sprite orange3;
	public Sprite orange4;
	public Sprite orange5;
	public Sprite orange6;
	public Sprite orange7;
	public Sprite orange8;
	public Sprite orange9;
	public Sprite orange10; 
	public GameObject blueBoard;
	public GameObject orangeBoard; 
	SpriteRenderer bsr; 
	SpriteRenderer osr;  
	public int pointsToWIn;
	public bool itsOver = false;  
	public GameObject blueText;
	public GameObject orangeText;
	public GameObject restartText; 
	public GameObject canvas; 


	// Use this for initialization
	void Start () {

		bsr = blueBoard.GetComponent<SpriteRenderer> ();
		osr = orangeBoard.GetComponent<SpriteRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		scoreUpdate ();
		gameEnder ();
		textDisplay ();
		
	}

	public void blueGoal () 
	{
		orangeScore++;
	}

	public void orangeGoal () 
	{
		blueScore++;
	}

	void scoreUpdate ()
	{
		if (blueScore == 0) 
		{
			bsr.sprite = blue0;
		}

		if (blueScore == 1) 
		{
			bsr.sprite = blue1;
		}

		if (blueScore == 2) 
		{
			bsr.sprite = blue2;
		}
		if (blueScore == 3) 
		{
			bsr.sprite = blue3;
		}

		if (blueScore == 4) 
		{
			bsr.sprite = blue4;
		}

		if (blueScore == 5) 
		{
			bsr.sprite = blue5;
		}
		if (blueScore == 6) 
		{
			bsr.sprite = blue6;
		}

		if (blueScore == 7) 
		{
			bsr.sprite = blue7;
		}

		if (blueScore == 8) 
		{
			bsr.sprite = blue8;
		}

		if (blueScore == 9) 
		{
			bsr.sprite = blue9;
		}

		if (blueScore == 10) 
		{
			bsr.sprite = blue10;
		}

		if (orangeScore == 0) 
		{
			osr.sprite = orange0;
		}

		if (orangeScore == 1) 
		{
			osr.sprite = orange1;
		}

		if (orangeScore == 2) 
		{
			osr.sprite = orange2;
		}
		if (orangeScore == 3) 
		{
			osr.sprite = orange3;
		}

		if (orangeScore == 4) 
		{
			osr.sprite = orange4;
		}

		if (orangeScore == 5) 
		{
			osr.sprite = orange5;
		}
		if (orangeScore == 6) 
		{
			osr.sprite = orange6;
		}

		if (orangeScore == 7) 
		{
			osr.sprite = orange7;
		}

		if (orangeScore == 8) 
		{
			osr.sprite = orange8;
		}

		if (orangeScore == 9) 
		{
			osr.sprite = orange9;
		}

		if (orangeScore == 10) 
		{
			osr.sprite = orange10;
		}

	}

	void gameEnder ()
	{
		if (orangeScore == pointsToWIn || blueScore == pointsToWIn) 
		{
			itsOver = true; 
		}

		if (Input.GetKeyDown (KeyCode.Space) && itsOver == true) 
		{
			EditorSceneManager.LoadScene (0);
		}
			
	}

	void textDisplay ()
	{
		if (blueScore == pointsToWIn) 
		{
			blueText.SetActive (true);
		}
			
		if (orangeScore == pointsToWIn) 
		{
			orangeText.SetActive (true);
		}
			
		if (orangeScore == pointsToWIn || blueScore == pointsToWIn) 
		{
			restartText.SetActive (true);
			canvas.SetActive (true);
		}
	}
}
