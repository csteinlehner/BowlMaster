using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMaster_old
{
	public enum Action{	Tidy, Reset, EndTurn, EndGame};

	private int[] bowls = new int[21];
	private int bowl = 1;


	public static Action NextAction(List<int> pinFalls){
		ActionMaster_old am = new ActionMaster_old ();
		Action currentAction = new Action ();

		foreach (int pinFall in pinFalls) {
			currentAction = am.Bowl (pinFall);
		}
		return currentAction;
	}
	private Action Bowl (int pins) // TODO make private
	{

		if (pins < 0 || pins > 10) {
			throw new UnityException ("Invalid pins");
		}

		bowls [bowl - 1] = pins;

		if (bowl == 21) {
			return Action.EndGame;
		}
		if (bowl == 20 && pins<10 && bowls[19-1]==10) {
			bowl += 1;
			return Action.Tidy;
		}
			
		if (bowl >= 19 && Bowl21Awarded ()) {
			bowl += 1;
			return Action.Reset;
		} else if (bowl == 20 && !Bowl21Awarded ()) {
			return Action.EndGame;
		}
			

		if (bowl % 2 != 0) { // First bowl of frame
			if (pins == 10) {
				bowl += 2;
				return Action.EndTurn;
			} else {
				bowl += 1;
				return Action.Tidy;
			}

		} else if (bowl % 2 == 0) {	// Second bowl of frame
			bowl += 1;
			return Action.EndTurn;
		}




		throw new UnityException ("Not sure what action to return!");
	}

	private bool Bowl21Awarded(){
		return (bowls [19 - 1] + bowls [20 - 1] >= 10);
	}
}	
