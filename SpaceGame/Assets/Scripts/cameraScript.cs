using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {



    public Transform _target;
    //private Rigidbody _rigidBody;


    void LateUpdate()
    {
        //origin = _transform. (_transform.position.x, _transform.position.y);
        transform.position = new Vector3(Mathf.Clamp(_target.position.x,0,11),Mathf.Clamp(_target.position.y,-1,5),transform.position.z);
        
    }
}
