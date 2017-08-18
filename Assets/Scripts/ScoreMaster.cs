using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMaster {


	// Returns a list of cumulative scores, lika a normal score card.
	public static List<int> ScoreCumulative (List<int> rolls){
		List<int> cumulativeScores = new List<int> ();
		int runningTotal = 0;
		foreach(int frameScore in ScoreFrames(rolls)){
			runningTotal += frameScore;
			cumulativeScores.Add(frameScore);
		}
		return cumulativeScores;
	}


	// List of individual frame scores, NOT cumulative
	public static List<int> ScoreFrames (List<int> rolls) {
		List<int> frameList = new List<int> ();

		bool endTurn = false;
		int turnPos = 0;
		int frameTotal = 0;

		for (int i = 0; i < rolls.Count; i++) {
			turnPos++;

			int rollVal = rolls [i];
			frameTotal += rollVal;
			if (rollVal == 10) {
				
				//endTurn=true;
				turnPos = 0;
			}
			if (turnPos == 2) {
				endTurn = true;
				turnPos = 0;
			}
				if(endTurn){
					frameList.Add(frameTotal);
					endTurn = false;
					frameTotal = 0;
				}

		}
		return frameList;
	}
}
