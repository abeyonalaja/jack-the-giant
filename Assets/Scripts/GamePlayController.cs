using UnityEngine;
using System.Collections;

public class GamePlayController : MonoBehaviour {
	
	public static GamePlayController instance;

	void GetInstance() {
		if(instance == null) {
			instance = this;
		}
	}
	
	void Awake() {
		GetInstance();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
