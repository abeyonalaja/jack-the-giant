using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {
	
	[SerializeField]
	private GameObject pausePanel;
	
	[SerializeField]
	private GameObject gameOverPanel;
	public static GamePlayController instance;
	
	[SerializeField]
	private Text scoreText;
	
	[SerializeField]
	private Text coinText;
	
	[SerializeField]
	private Text lifeText;
	
	[SerializeField]
	private Text gameOverScoreText;
	
	[SerializeField]
	private Text gameOverCoinText;
	

	void GetInstance() {
		if(instance == null) {
			instance = this;
		}
	}
	
	public void GameOverShowPanel(int finaleScore, int finaleCoinScore) {
		gameOverPanel.SetActive(true);
		gameOverScoreText.text = finaleScore.ToString();
		gameOverCoinText.text = finaleCoinScore.ToString();
		StartCoroutine(GameOverLoadMainMenu());
	}
	
	IEnumerator GameOverLoadMainMenu() {
		yield return new WaitForSeconds(3f);
		Application.LoadLevel("MainMenu");
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
	
	public void SetScore(int score) {
		scoreText.text = "x" + score;
	}
	
	public void SetCoinScore(int coinScore){
		coinText.text = "x" + coinScore;
	}
	
	public void setLifeScore(int lifeScore){
		lifeText.text = "x" + lifeScore;
	}
}
