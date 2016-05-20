﻿using UnityEngine;
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
	
	}
	
	void CountScore() {
		if(countScore) {
			if(transform.position.y < previuosPosition.y) {
				scoreCount++;
			}
			previuosPosition = transform.position;
		}
	}
}