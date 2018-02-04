using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	private CharacterController controller;

	public float speed = 0.25f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		controller.Move(Vector3.forward * speed * Time.deltaTime);
	}
}
