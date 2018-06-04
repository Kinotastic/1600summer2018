using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
	public float HealthLevel = 1.0f;
	public float EvilPower = 0.1f;
	public HealthBehaviour PlayerHealthBehaviour;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void OnTriggerEnter ()
	{
		HealthLevel -= EvilPower;
		PlayerHealthBehaviour.HealthLevel = HealthLevel;
	}
}