using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {


	public void Update () {

		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("park");
			SceneManager.UnloadScene ("startscreen");
		}
		
	}
}
