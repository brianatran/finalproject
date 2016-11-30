using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnStart : MonoBehaviour {


	public void Update () {

		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("startscreen");
			SceneManager.UnloadScene ("gameover");
		}

	}
}
