﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {


	private CharacterController controller;
	private Vector3 newPosition;
	public float Speed = 10.0f;
	//private variables behin lowercase, public variables begin capitalized. They still have camel casing.
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
