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
		bool frameFull = false;
		int frameTotal = 0;
		for (int i = 1; i <= rolls.Count; i++) {
			frameTotal += rolls[i-1];
		
			if (rolls [i - 1] == 10) {
				frameFull = true;
			}else if (i % 2 == 0 && i != 1) {
				frameFull = true;
			}


			if (frameFull) {
				frameList.Add (frameTotal);
				frameTotal = 0;
				frameFull = false;
			}
		}
	

		return frameList;
	}
}
