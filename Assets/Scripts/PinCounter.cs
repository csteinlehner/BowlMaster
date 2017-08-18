using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinCounter : MonoBehaviour {
	public Text standingDisplay;


	private GameManager gameManager;
	private int lastStandingCount = -1;
	private float lastChangeTime;
	private int lastSettledCount = 10;
	private bool ballLeftBox = false;



	// Use this for initialization
	void Start () {
		gameManager = GameObject.FindObjectOfType<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		standingDisplay.text = CountStanding ().ToString ();

		if (ballLeftBox) {
			UpdateStandingCountAndSettle ();
		}
	}

	public void Reset(){
		lastSettledCount = 10;
	}

	int CountStanding ()
	{
		int standingPins = 0;
		foreach (Pin pin  in GameObject.FindObjectsOfType<Pin>()) {
			if (pin.IsStanding ()) {
				standingPins++;
			}
		}
		return standingPins;
	}

	void UpdateStandingCountAndSettle ()
	{
		int currentStanding = CountStanding ();

		if (currentStanding != lastStandingCount) {
			lastChangeTime = Time.time;
			lastStandingCount = currentStanding;
			return;
		}

		float settleTime = 3f;
		if ((Time.time - lastChangeTime) > settleTime) {
			PinsHaveSettled ();
		}
	}

	void PinsHaveSettled ()
	{

		int standing = CountStanding ();
		int pinFall = lastSettledCount - standing;
		lastSettledCount = standing;

		gameManager.Bowl (pinFall);
		lastStandingCount = -1; // Indicates have settled
		ballLeftBox = false;
		standingDisplay.color = Color.green;

	}

	void OnTriggerExit(Collider col){
		GameObject thingHit = col.gameObject;
		if (thingHit.GetComponent<Ball> ()) {
			ballLeftBox = true;
		}
	}
}
