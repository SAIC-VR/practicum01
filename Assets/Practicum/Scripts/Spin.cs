// VR at SAIC 
// UnityScritping
// Basic scripts to get started with scripting in Unity 3D
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	public float speed = 10f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, speed);
		
	}
}
