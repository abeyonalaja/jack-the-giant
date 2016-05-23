using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {
	[SerializeField]
	private AudioClip coinClip;
	
	[SerializeField]
	private AudioClip lifeClip;
	
	private CameraController cameraController;
	
	private Vector3 previuosPosition;
	private bool countScore;
	
	public static int scoreCount;
	public static int lifeCount;
	public static int coinCount;

	void Awake() {
		cameraController = Camera.main.GetComponent<CameraController>();
		
	}
	// Use this for initialization
	void Start () {
		previuosPosition = transform.position;
	GamePlayController.instance.SetCoinScore(0);
		GamePlayController.instance.SetScore(0);
		countScore = true;
	}
	
	// Update is called once per frame
	void Update () {
		CountScore();
	}
	
	void CountScore() {
		if(countScore) {
			if(transform.position.y < previuosPosition.y) {
				scoreCount++;
			}
			previuosPosition = transform.position;
			GamePlayController.instance.SetScore(scoreCount);
			
		}
	}
	
	void OnTriggerEnter2D(Collider2D target) {
		
		if(target.tag == "Coin") {
			coinCount++;
			scoreCount += 200;
			
			GamePlayController.instance.SetScore(scoreCount);
			GamePlayController.instance.SetCoinScore(coinCount);
			
			AudioSource.PlayClipAtPoint(coinClip, transform.position);
			target.gameObject.SetActive(false);
		}
		
		if(target.tag == "Life"){
			lifeCount++;
			scoreCount += 300;
			
			GamePlayController.instance.SetScore(scoreCount);
			GamePlayController.instance.setLifeScore(lifeCount);
			
			AudioSource.PlayClipAtPoint(lifeClip, transform.position);
			target.gameObject.SetActive(false);
		}
		
		if(target.tag == "Bounds"){
			cameraController.moveCamera = false;
			countScore = false;
			
			lifeCount--;
			transform.position = new Vector3(500, 500, 0);
		}
		
		if(target.tag == "Deadly") {
			Debug.Log("GRRRR DEADLY");
			cameraController.moveCamera = false;
			countScore = false;
			
			lifeCount--;
			transform.position = new Vector3(500, 500, 0);
		}
	}
}
