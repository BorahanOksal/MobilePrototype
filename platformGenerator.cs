﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour {

	public GameObject Ground;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	// Use this for initialization
	void Start () {
		platformWidth = Ground.GetComponent<BoxCollider2D>().size.x;
	}

	// Update is called once per frame
	void Update () {

		if(transform.position.x < generationPoint.position.x)
		{
			transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

			Instantiate(Ground, transform.position, transform.rotation);
		}
	}
}
