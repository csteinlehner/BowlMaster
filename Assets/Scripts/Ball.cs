using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public Vector3 launchVelocity;
	public bool inPlay = false;

	private Rigidbody rigidBody;
	private AudioSource audioSource;
	private Vector3 ballStartPos;

	// Use this for initialization
	void Start ()
	{
		ballStartPos = this.transform.position;
		rigidBody = this.GetComponent<Rigidbody> ();
		rigidBody.useGravity = false;
	}

	public void Launch (Vector3 velocity)
	{
		inPlay = true;

		rigidBody.useGravity = true;
		rigidBody.velocity = velocity;

		audioSource = this.GetComponent<AudioSource> ();
		audioSource.Play ();
	}

	public void Reset ()
	{
		Debug.Log ("Reseting ball");
		inPlay = false;
		rigidBody.useGravity = false;
		rigidBody.velocity = Vector3.zero;
		rigidBody.angularVelocity = Vector3.zero;

		this.transform.position = ballStartPos;
		this.transform.rotation = Quaternion.identity;
	}
}
