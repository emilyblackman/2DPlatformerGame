using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleController : MonoBehaviour {


	public float speed = 10;
	public float jumpvelocity = 10;
	public LayerMask playerMask;
	public bool canmoveinair = true;
	Transform myTransform, tagGround;
	Rigidbody2D mybody;
	public bool isground = false;


	// Use this for initialization
	void Start () {
		mybody = GetComponent<Rigidbody2D> ();
		myTransform = GetComponent<Transform>();
		tagGround = GameObject.Find(this.name + "/TagGround").transform;
	}

	// Update is called once per frame
	void FixedUpdate () {

		isground = Physics2D.Linecast (myTransform.position, tagGround.position, playerMask);
		Move (Input.GetAxisRaw("Horizontal"));
		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}
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
}