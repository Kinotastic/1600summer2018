using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {

	public enum WeaponType
	{
		Axe,
		Club,
		Sword,
		Spear,
		Scimitar,
	}
		
	public WeaponType CurrentWeapon;

	void Update()
	{
		switch (CurrentWeapon)
		{
			case WeaponType.Axe:
			Debug.Log(CurrentWeapon);
			break;

			case WeaponType.Club:
			Debug.Log(CurrentWeapon);
			break;

			case WeaponType.Sword:
			Debug.Log(CurrentWeapon);
			break;

			case WeaponType.Spear:
			Debug.Log(CurrentWeapon);
			break;

			case WeaponType.Scimitar:
			Debug.Log(CurrentWeapon);
			break;
		}
	}

}
