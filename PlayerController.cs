using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static PlayerController instance;
	public float Rise = 300f; 
	public float Speed = 15f;
	public Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch (i).phase == TouchPhase.Began)
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * Rise);
		}

		Vector2 newVelocity = GetComponent<Rigidbody2D>().velocity;
		newVelocity.x = Speed;
		GetComponent<Rigidbody2D>().velocity = newVelocity;
	}
  }

