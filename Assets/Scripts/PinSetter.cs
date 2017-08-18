﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour
{
	

	public GameObject pinSet;

	private PinCounter pinCounter;
	private Animator animator;

	// Use this for initialization
	void Start ()
	{
		
		animator = GetComponent<Animator> ();
		pinCounter = GameObject.FindObjectOfType<PinCounter> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void RaisePins ()
	{
		foreach (Pin pin  in GameObject.FindObjectsOfType<Pin>()) {
			pin.RaiseIfStanding ();
		}
	}

	public void LowerPins ()
	{	
		foreach (Pin pin  in GameObject.FindObjectsOfType<Pin>()) {
			pin.Lower ();
		}
	}

	public void RenewPins ()
	{
		GameObject newPins = Instantiate (pinSet);
		newPins.transform.position += new Vector3 (0, 50, 0);

	}

	public void PerformAction(ActionMaster.Action action){

		if (action == ActionMaster.Action.Tidy) {
			animator.SetTrigger ("tidyTrigger");
		} else if (action == ActionMaster.Action.EndTurn) {
			animator.SetTrigger ("resetTrigger");
			pinCounter.Reset ();
		} else if (action == ActionMaster.Action.Reset) {
			animator.SetTrigger ("resetTrigger");
			pinCounter.Reset ();
		}else if(action == ActionMaster.Action.EndGame){
			pinCounter.Reset ();
			throw new UnityException ("Don't know how to handle an EndGame Action");
		}
	}


}
