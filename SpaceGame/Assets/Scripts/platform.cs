using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {

	private BoxCollider2D _platformCollider;

	void Awake	() {
		_platformCollider = GetComponent<BoxCollider2D>();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

