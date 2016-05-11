using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 8f;
	public float maxVelocity = 4;
	
	private Rigidbody2D playerBody;
	private Animator playerAnimatior;
	
	void Awake() {
		playerBody = GetComponent<Rigidbody2D>();
		playerAnimatior = GetComponent<Animator>();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate() {
		PlayerMoveKeyboard();
	}
	
	void PlayerMoveKeyboard() {
		float forceX = 0f;
		float vel = Mathf.Abs(playerBody.velocity.x);
		
		float h = Input.GetAxisRaw("Horizontal");
		
		if(h > 0) {
			playerAnimatior.SetBool("Walk", true);
			Vector3 temp = transform.localScale;
			temp.x = 1.3f;
			transform.localScale = temp;
			if(vel < maxVelocity)
				forceX = speed;
		} else if(h < 0) {
			playerAnimatior.SetBool("Walk", true);
			Vector3 temp = transform.localScale;
			temp.x = -1.3f;
			transform.localScale = temp;
			if(vel < maxVelocity)
				forceX = -speed;
		} else {
			playerAnimatior.SetBool("Walk", false);
		}
		
		playerBody.AddForce(new Vector2(forceX, 0) );
	}
}
