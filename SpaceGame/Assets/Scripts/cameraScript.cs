using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

    

    [SerializeField]
    public Transform objectA;
 
    private Transform _transform;

    void Awakes()
    {
        _transform = GetComponent<Transform>();    
    }

    void Update()
    {
        _transform.TransformPoint(objectA.position.x, _transform.position.y, _transform.position.z);
    }
}
