using UnityEngine;
using System.Collections;

public class My_LoadNewScene : MonoBehaviour
{
	public string scene;


	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Player")
		{
			StartCoroutine(LoadScene());
		}
	}

	IEnumerator LoadScene()
	{			
		// ... pause briefly
		yield return new WaitForSeconds(0.01f);
		// ... and then reload the level.
		Application.LoadLevel(scene);
	}
}
