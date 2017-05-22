using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private bool jumping;
	private BoxCollider _playerCollider;
	private Rigidbody _rigidBody;
	private platform _platform;
    private float x;

	void Awake(){
		_playerCollider = GetComponent<BoxCollider>();
		_rigidBody = GetComponent<Rigidbody>();
		_platform = GetComponent<platform>();
	}

	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(transform.position, Vector3.down, 1))
        {
            _rigidBody.AddForce(Input.GetAxis("Horizontal") * 10, 0, 0);
        }
        if (Input.GetButtonDown("Jump") && Physics.Raycast(transform.position, Vector3.down, 1))
		{
			_rigidBody.AddForce (Vector3.up * 300);
            _rigidBody.AddForce (Input.GetAxis("Horizontal")*2,0,0);
		}
	}
}
