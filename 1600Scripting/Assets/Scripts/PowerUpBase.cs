using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : ScriptableObject {

    public Animal AnyAnimal;

    public void RunPowerUp()
    {
        AnyAnimal.Health += PowerLevel;
        //add value in addition to the value that already exists
    }

    [Range(-10,10)] public float PowerLevel = 1.0f;
    private void OnEnable()
    {
        Debug.Log("PowerUp");
    }
}
