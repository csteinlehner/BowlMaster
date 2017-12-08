using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private List<int> rolls = new List<int>();
	private PinSetter pinSetter;
	private Ball ball;
    private ScoreDisplay scoreDisplay;

	// Use this for initialization
	void Start () {
		pinSetter = GameObject.FindObjectOfType<PinSetter> ();
		ball = GameObject.FindObjectOfType<Ball> ();
        scoreDisplay = GameObject.FindObjectOfType<ScoreDisplay>();
    }
	
	public void Bowl (int pinFall){
        try { 
		rolls.Add (pinFall);
        ball.Reset();

		pinSetter.PerformAction(ActionMaster.NextAction(rolls));
        } catch
        {
            Debug.LogWarning("Something went wrong in Bowl()");
        }
        try
        {
            scoreDisplay.FillRolls(rolls);
            scoreDisplay.FillFrames(ScoreMaster.ScoreCumulative(rolls));
        } catch
        {
            Debug.LogWarning("Score display couldn't be updated");
        }
        
        
		
	}
}
