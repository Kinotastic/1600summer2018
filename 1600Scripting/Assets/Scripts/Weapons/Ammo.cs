using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

	private Rigidbody projectile;
	public float ProjectileSpeed = 1000;

	private void Start () {
		projectile = GetComponent<Rigidbody>();
		projectile.AddForce(0,0,ProjectileSpeed);
	}
}
