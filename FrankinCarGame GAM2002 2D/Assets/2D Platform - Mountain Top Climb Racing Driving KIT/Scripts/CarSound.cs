using UnityEngine;
using System.Collections;

public class CarSound : MonoBehaviour {

		private AudioSource carSound;
		private const float lowest = 0.5f;
		private const float highest = 3f;
		private const float reductionFactor = .001f;

		private float userInput;
		WheelJoint2D wj;

		void Awake ()
		{
			carSound = GetComponent<AudioSource>();
			wj = GetComponent<WheelJoint2D>();
		}

		void FixedUpdate()
		{
			userInput = Input.GetAxis("Horizontal");
			float forwardSpeed =Mathf.Abs(wj.jointSpeed);
			float pitchFactor = Mathf.Abs (forwardSpeed * reductionFactor * userInput) ;
			carSound.pitch = Mathf.Clamp (pitchFactor, lowest, highest);
		}

	/* void OnTriggerEnter2D(Collider2D otherObject)
	{
		if (otherObject.tag == "ground")
		{
			Destroy (this);
			Destroy (GetComponent<AudioSource>());
		}

	}
*/

	}

