using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pfile : MonoBehaviour {

	public void ChangeScene(){
		SceneManager.LoadScene ("Leaderboard");
	}
	public void ChangeScene1(){
		SceneManager.LoadScene ("gameselection");
	}
	public void ChangeScene2(){
		SceneManager.LoadScene ("profile");
	}
}

