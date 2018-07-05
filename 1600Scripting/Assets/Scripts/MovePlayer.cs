using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {


	private CharacterController controller;
	private Vector3 newPosition;
	public float Speed = 10.0f;
	//private variables begin lowercase 
	//public variables begin capitalized
	//they still have camel casing
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	void Update () {
		newPosition.x = Speed*Input.GetAxis("Horizontal");
		controller.Move(newPosition * Time.deltaTime);
	}
}
