using UnityEngine;
using System.Collections;

public class TurnOverGameEndSound : MonoBehaviour {

	public AudioClip EndGameSound;
	public AudioClip EndGameSound2;

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		if (otherObject.tag == "ground")
		{
			GetComponent<AudioSource>().PlayOneShot(EndGameSound, 7.7F);
			GetComponent<AudioSource>().PlayOneShot(EndGameSound2, 7.7F);
		}

	}
}