using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTransform : MonoBehaviour {

	public GameObject Target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 targetPosition = new Vector3 (Target.transform.position.x, transform.position.y, Target.transform.position.z);
		transform.LookAt (targetPosition);
	}
}
