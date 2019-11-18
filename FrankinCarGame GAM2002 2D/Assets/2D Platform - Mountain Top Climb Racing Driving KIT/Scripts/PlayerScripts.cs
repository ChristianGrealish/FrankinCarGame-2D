using UnityEngine;
using System.Collections;

public class PlayerScripts : MonoBehaviour {

    public static int score;
	public static int fuel;
    bool showGUI = true;
	bool showGUI1 = false;
	bool paused = false;
	public AudioClip FuelSound;
	public AudioClip ScoreSound;
	public Texture HealthHUD;
	public Texture ScoreHUD;
	public Texture EndGameHud;
	public Texture EndGameHud2;
	public Texture WinGameFullScreen;
	public Texture WinGameScoreBoard;
	float m_Timer = 3.0f;
	public GUIStyle DisplayScore = new GUIStyle();



	void Start () {
	score = 0;
	fuel = 100;

	   
	}
	
	// Update is called once per frame
	void Update () {

		m_Timer -= Time.deltaTime;
		if(m_Timer <= 0.0f)

		{
			fuel--;
			fuel--;
			m_Timer = 3.0f;
		}
			

		if (Input.GetKeyDown (KeyCode.P)) {
			paused = !paused;
		}
		if (paused == true) {
			Time.timeScale = 0f;
		} else { Time.timeScale = 1f;
		}
		
		//float randomX = 0f;
		//float randomY = 0f;



		if (paused == false) {
		//Debug.Log (numberofasteroids > 0);
			if ((fuel > 0))
        {
        }
        else
        {
            showGUI = false;
        }
		}
		}


    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.tag == "enemy")
        {
			fuel = 0;
        }
        if (otherObject.tag == "fuel")
        {
			fuel += 5;
			GetComponent<AudioSource>().PlayOneShot(FuelSound, 7.7F);
            Destroy(otherObject.gameObject);
    	}
		if (otherObject.tag == "score")
		{
			score++;
			GetComponent<AudioSource>().PlayOneShot(ScoreSound, 7.7F);
			Destroy(otherObject.gameObject);
		}
		if (otherObject.tag == "win")
		{
			//score++;
			showGUI1 = true;
		}
	}



    void OnGUI()
    {
        if (showGUI)
        {
            GUI.color = Color.white;
			GUI.Label(new Rect(42, 73, 100, 25), "<b>Fuel:</b> " + fuel);
			GUI.Label(new Rect(42, 100, 100, 25), "<b>Score:</b> " + score);
			GUI.DrawTexture(new Rect(10, 45, 80, 80), HealthHUD, ScaleMode.ScaleToFit, true, 0.0F);
			GUI.DrawTexture(new Rect(10, 73, 80, 80), ScoreHUD, ScaleMode.ScaleToFit, true, 0.0F);
        }
        else
        {
			if (fuel ==0)
			{ 
				
			if (fuel ==0)
			{
					GetComponent<AudioSource>().enabled = false;
				//Destroy (GetComponent<AudioSource>());
				//AudioListener.volume = 0.0F;
				//Destroy (GameObject.FindWithTag("Controller"));
				GUI.DrawTexture(new Rect(((Screen.width / 2) - 808f), ((Screen.height / 5) - 941.5f), 1900, 1925), EndGameHud, ScaleMode.ScaleToFit, true, 0.0F);
				GUI.DrawTexture(new Rect(((Screen.width / 2) - 248f), ((Screen.height / 2) - 401.5f), 500, 695), EndGameHud2, ScaleMode.ScaleToFit, true, 0.0F);
				DisplayScore.normal.textColor = Color.white;
				//guiStyle.alignment = TextAnchor.MiddleCenter;
				GUI.Label (new Rect(Screen.width / 2 - 48f, ((Screen.height / 2) - 34.5f), 40, -210), " "+score, DisplayScore);
				if (Input.GetMouseButtonDown(0)) {
				Application.LoadLevel ("Menu");
				}
				if (Time.timeScale == 1.0F)
					Time.timeScale = 0.5F;
				else
					Time.timeScale = 0.01F;
				Time.fixedDeltaTime = 0.02F * Time.timeScale;
				}
			}
		}
					
					if (showGUI1)
					
					{
					GUI.DrawTexture(new Rect(((Screen.width / 2) - 808f), ((Screen.height / 5) - 741.5f), 1900, 1925), WinGameFullScreen, ScaleMode.ScaleToFit, true, 0.0F);
					GUI.DrawTexture(new Rect(((Screen.width / 2) - 248f), ((Screen.height / 2) - 401.5f), 500, 695), WinGameScoreBoard, ScaleMode.ScaleToFit, true, 0.0F);
					GUI.Label (new Rect(Screen.width / 2 - 48f, ((Screen.height / 2) - 34.5f), 40, -210), " "+score, DisplayScore);
					if (Input.GetMouseButtonDown(0)) {
						{
							int currentLevel = Application.loadedLevel;
							Debug.Log(currentLevel);
							if (currentLevel < Application.levelCount-1)
							{
								Application.LoadLevel(currentLevel + 1);
							}
							else
							{
								Application.LoadLevel(0);	
        				}
  		 			} 
				}
			}
		}
	}
