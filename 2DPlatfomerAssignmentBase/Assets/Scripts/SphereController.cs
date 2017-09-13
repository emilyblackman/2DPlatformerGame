using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float threshold = -20;
	public float speed = 10;
	public float jumpvelocity = 10;
	public LayerMask playerMask;
	public bool canmoveinair = true;
	Transform myTransform, tagGround;
	Rigidbody2D mybody;
	bool isground = true;
	private Vector2 pos;


	// Use this for initialization
	void Start () {
		mybody = GetComponent<Rigidbody2D> ();
		myTransform = GetComponent<Transform>();
		pos = myTransform.position;
		//tagGround = GameObject.Find(this.name + "/Tag Ground").transform;
	}

	// Update is called once per frame
	void FixedUpdate () {

		//isground = Physics2D.Linecast (myTransform.position, tagGround.position, playerMask);
		Move (Input.GetAxisRaw("Horizontal"));
		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}

		if (transform.position.y < threshold)
			Respawn();	
	}


	public void Move(float horzontalInput){
		if (!canmoveinair && !isground)
			return;
		Vector2 moveVel = mybody.velocity;
		moveVel.x = horzontalInput * speed;
		mybody.velocity = moveVel;

	}

	public void Jump(){
		if (isground)
			mybody.velocity += jumpvelocity * Vector2.up;

	}

	public void Respawn() {
		transform.position = pos;
	}
}