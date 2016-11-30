using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnGameOver : MonoBehaviour {


	public void Update () {

		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("gameover");
			SceneManager.UnloadScene ("park");
		}
		else if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("gameover");
			SceneManager.UnloadScene ("pink");
		}
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("gameover");
			SceneManager.UnloadScene ("winter");
		}

	}
}