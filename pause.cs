using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

	public GameObject PAUSE;
	public GameObject settings1;
	bool GamePaused;

	void Start () {
		GamePaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GamePaused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
		
	}

	public void PausedGame(){
		GamePaused = true;
		PAUSE.SetActive (true);
		settings1.SetActive (false);
	}

	public void ResumeGame(){
		GamePaused = false;
		PAUSE.SetActive (false);
		settings1.SetActive (true);
	}
}
