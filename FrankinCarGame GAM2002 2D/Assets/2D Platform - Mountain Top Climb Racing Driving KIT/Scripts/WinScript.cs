using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

	public AudioClip WinGameSound;

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		if (otherObject.tag == "win")
		{
			GetComponent<AudioSource>().PlayOneShot(WinGameSound, 7.7F);
			//PlayerScripts.fuel = 500;
		}

	}
}