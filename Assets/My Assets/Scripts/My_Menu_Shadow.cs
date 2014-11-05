using UnityEngine;
using System.Collections;

public class My_Menu_Shadow : MonoBehaviour
{
	//public int score = 0;					// The player's score.
	//public string scene;

	void Awake ()
	{
		// Setting up the reference.
		//playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}


	void Update ()
	{
		// Set the score text.
		this.guiText.text = GameObject.Find("Menu").GetComponent<GUIText>().text;
	
		// If the score has changed...
		/*if (previousScore != score)
			// ... play a taunt.
			playerControl.StartCoroutine(playerControl.Taunt());

		// Set the previous score to this frame's score.
		previousScore = score;*/
	}

}
