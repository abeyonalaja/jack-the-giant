using UnityEngine;
using System.Collections;

public class BackgroundScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		SpriteRenderer spriteRender = GetComponent<SpriteRenderer>();
		Vector3 tempScale = transform.localScale;
		
		float width = spriteRender.sprite.bounds.size.x;
		
		float worldHeight = Camera.main.orthographicSize * 2.0f;
		float worldWidth = worldHeight / Screen.height * Screen.width;
		
		tempScale.x = worldWidth / width;
		
		transform.localScale = tempScale;
	}
	
}
