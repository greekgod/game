using UnityEngine;
using System.Collections;

public class My_Menu : MonoBehaviour
{
	//public int score = 0;					// The player's score.
	public string scene;

	void Awake ()
	{
		// Setting up the reference.
		//playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}


	void Update ()
	{
		// Set the score text.
		guiText.text = "Bibizin's Adventure:\n A volta dos que nao foram\n\n\n[Pressione qualquer tecla]";

		if (Input.anyKey) 
		{

			Application.LoadLevel(scene);
		}
		// If the score has changed...
		/*if (previousScore != score)
			// ... play a taunt.
			playerControl.StartCoroutine(playerControl.Taunt());

		// Set the previous score to this frame's score.
		previousScore = score;*/
	}

}
