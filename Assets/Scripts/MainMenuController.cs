using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void OnStartButtonClick() {
		// Application.LoadLevel("main");
		SceneManager.LoadScene("main");
	}
	
	public void OnHighScoreButtonClick() {
		SceneManager.LoadScene("HighScoreScene");
	}
	
	public void OnOptionsButtonClick() {
		SceneManager.LoadScene("OptionsMenuScene");
	}
	
	public void OnQuitButtonClick() {
		Application.Quit();
	}
}
