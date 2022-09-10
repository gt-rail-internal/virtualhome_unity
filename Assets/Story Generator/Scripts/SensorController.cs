using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	Rigidbody rigidbody;
	Camera viewCamera;

	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		viewCamera = Camera.main;
	}

	void Update () {
		// Add code
	}
}