using UnityEngine;
using System.Collections;

public class GamePlayController : MonoBehaviour {
	
	[SerializeField]
	private GameObject pausePanel;
	public static GamePlayController instance;

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
}
