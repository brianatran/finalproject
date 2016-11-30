using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDownPink : MonoBehaviour{

	float timeLeft = 30.0f;

	public Text text;



	void Update()
	{
		timeLeft -= Time.deltaTime;
		text.text = "TIME: " + Mathf.Round(timeLeft);
		if(timeLeft < 0)
		{
			SceneManager.LoadScene("winter");
		}
	}
}
