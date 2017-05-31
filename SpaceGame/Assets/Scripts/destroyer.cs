using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

    private colliderP _collider;

    void Awake()
    {
        _collider = GetComponent<colliderP>();
    }

    void OnTriggerEnter(Collider detect)
    {

    }
}
