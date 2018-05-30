using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehaviour : MonoBehaviour {

    public Animal AnimalInfo;

    void OnTriggerEnter()
    {
        AnimalInfo.UpdateHealth();
    }

}
