using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KeyPressed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene ("gameover");
	
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			SceneManager.LoadScene ("gameover");
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			SceneManager.LoadScene ("gameover");
		}
		else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			SceneManager.LoadScene ("gameover");
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			SceneManager.LoadScene ("gameover");
		}


	
	}
}
