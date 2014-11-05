using UnityEngine;
using System.Collections;

public class My_Score : MonoBehaviour
{
	public int score = 0;					// The player's score.
	
	void Awake ()
	{
		// Setting up the reference.
		//playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}


	void Update ()
	{
		// Set the score text.
		guiText.text = "Score: " + score;

		// If the score has changed...
		/*if (previousScore != score)
			// ... play a taunt.
			playerControl.StartCoroutine(playerControl.Taunt());

		// Set the previous score to this frame's score.
		previousScore = score;*/
	}

}
