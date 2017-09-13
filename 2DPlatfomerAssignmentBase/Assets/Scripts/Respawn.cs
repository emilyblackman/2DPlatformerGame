using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {
	public float threshold = -20;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {
		if (transform.position.y < threshold)
			transform.position = new Vector3(0, 0, 0);
	}
}
