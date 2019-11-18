using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horn : MonoBehaviour {

	public AudioClip audio01;
	void  Update (){
		if (Input.GetKeyDown ("h"))
		{
			GetComponent<AudioSource>().PlayOneShot(audio01);
			//GetComponent<AudioSource>().PlayOneShot(ScoreSound, 7.7F);
		}
	}
}