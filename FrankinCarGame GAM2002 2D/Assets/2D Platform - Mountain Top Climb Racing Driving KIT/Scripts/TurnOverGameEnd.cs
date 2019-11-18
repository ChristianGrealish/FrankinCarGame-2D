using UnityEngine;
using System.Collections;

public class TurnOverGameEnd : MonoBehaviour {

	public AudioClip EndGameSound;
	public AudioClip EndGameSound2;
	//int getfuel=PlayerScripts;

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		if (otherObject.tag == "ground")
		{
			GetComponent<AudioSource>().PlayOneShot(EndGameSound, 7.7F);
			GetComponent<AudioSource>().PlayOneShot(EndGameSound2, 7.7F);
			PlayerScripts.fuel = 0;
			//fuel.instance.CurrentScore = 10; // Or Whatever
			//PlayerScripts.fuel = 0;
		}

	}
}