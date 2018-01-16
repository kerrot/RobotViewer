using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

	[SerializeField] private string sceneName1 = "Space";
	[SerializeField] private string sceneName2 = "Ocean";

	string currentScene;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad(gameObject);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeScene(string name)
	{
		if (currentScene != name)
		{
			SceneManager.LoadScene(name);
			currentScene = name;
		}
	}
}
