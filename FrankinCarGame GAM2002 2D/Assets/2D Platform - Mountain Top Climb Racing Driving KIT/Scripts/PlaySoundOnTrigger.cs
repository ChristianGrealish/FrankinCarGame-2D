using UnityEngine;
using System.Collections;

public class PlaySoundOnTrigger : MonoBehaviour {

	public AudioClip SoundToPlay;

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		if (otherObject.tag == "playsound")
		{
			GetComponent<AudioSource>().PlayOneShot(SoundToPlay, 7.7F);
		}

	}
}