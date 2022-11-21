using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class prof : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void ChangeScene(){
		SceneManager.LoadScene ("d2");
	}
	public void ChangeScene1(){
		SceneManager.LoadScene ("d1");
	}
	public void ChangeScene2(){
		SceneManager.LoadScene ("d3");
	}
}


