using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
	public float standingThreshold = 3f;
	public float distanceToRaise = 50f;

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
	{
		rigidBody = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public bool IsStanding ()
	{
		Vector3 rotationInEuler = transform.rotation.eulerAngles;
		if (Mathf.Abs (270 - rotationInEuler.x) > standingThreshold || Mathf.Abs (rotationInEuler.z) > standingThreshold) {
			return false;
		} else {
			return true;
		}
	}

	public void RaiseIfStanding ()
	{
		if (this.IsStanding ()) {
			rigidBody.useGravity = false;
			this.transform.Translate (new Vector3 (0, distanceToRaise, 0), Space.World);
			this.transform.rotation = Quaternion.Euler (270f, 0, 0);
		}
	}

	public void Lower ()
	{
		this.transform.Translate (new Vector3 (0, -distanceToRaise, 0), Space.World);
		rigidBody.useGravity = true;
	}
}
