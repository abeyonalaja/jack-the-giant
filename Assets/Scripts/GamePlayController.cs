using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {
	
	[SerializeField]
	private GameObject pausePanel;
	public static GamePlayController instance;
	
	[SerializeField]
	private Text scoreText;
	
	[SerializeField]
	private Text coinText;
	
	[SerializeField]
	private Text lifeText;
	

	void GetInstance() {
		if(instance == null) {
			instance = this;
		}
	}
	
	void Awake() {
		GetInstance();
	}
	
	public void PauseGame() {
		Time.timeScale = 0f;
		pausePanel.SetActive(true);
	}
	
	public void ResumeGame() {
		Time.timeScale = 1f;
		pausePanel.SetActive(false);
	}
	
	public void QuitGame() {
		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu");
	}
}
