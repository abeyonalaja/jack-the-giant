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
	public static int lifeScore;
	public static int coinScore;

	void Awake() {
		cameraController = Camera.main.GetComponent<CameraController>();
	}
	// Use this for initialization
	void Start () {
		previuosPosition = transform.position;
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
		}
	}
	
	void OnTriggerEnter2D(Collider2D target) {
		
		if(target.tag == "Coin") {
			coinScore++;
			scoreCount += 200;
			
			AudioSource.PlayClipAtPoint(coinClip, transform.position);
			target.gameObject.SetActive(false);
		}
		
		if(target.tag == "Life"){
			lifeScore++;
			scoreCount += 300;
			
			AudioSource.PlayClipAtPoint(lifeClip, transform.position);
			target.gameObject.SetActive(false);
		}
		
		if(target.tag == "Bounds"){
			cameraController.moveCamera = false;
			countScore = false;
		}
	}
}
