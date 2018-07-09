using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

	public bool StartGame = true;
	public int i = 3;

	void Start () {
		StartCoroutine(Ticker());
	}

	IEnumerator Ticker()
	{
		while (i > 0)
		{
			print(i);
			yield return new WaitForSeconds(1);
			i--;
		}

		print("GO!");
	}
}
