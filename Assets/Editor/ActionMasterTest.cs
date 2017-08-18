using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using System.Linq;

[TestFixture]
public class ActionMasterTest
{
	private List<int> pinFalls;
	private ActionMaster.Action endTurn = ActionMaster.Action.EndTurn;
	private ActionMaster.Action tidy = ActionMaster.Action.Tidy;
	private ActionMaster.Action reset = ActionMaster.Action.Reset;
	private ActionMaster.Action endGame = ActionMaster.Action.EndGame;



	[SetUp]
	public void Setup(){
		pinFalls = new List<int> ();
	}

//	[Test]
//	public void T00PassingTest(){
//		Assert.AreEqual (1, 1);
//	}
//
//	[Test]
//	public void T01OneStrikeReturnsEndTurn(){
//		pinFalls.Add (10);
//		Assert.AreEqual (endTurn, ActionMaster.NextAction(pinFalls));
//	}
//
//	[Test]
//	public void T02Bowl8ReturnsTidy(){
//		pinFalls.Add (8);
//		Assert.AreEqual (tidy, ActionMaster.NextAction(pinFalls));
//	}
//
//	[Test]
//	public void T03Bowl82ReturnsEndTurn(){
//		int[] rolls = { 8, 2 };
//		Assert.AreEqual (endTurn, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T04CheckResetAtStrikeInLastFrame(){
//		int[] rolls = {1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1,10};
//		Assert.AreEqual(reset, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T05CheckResetAtStrikeInLastFrame(){
//		int[] rolls = {1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1, 9};
//		Assert.AreEqual(reset, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T06CheckEndGame(){
//		int[] rolls = {8,2, 7,3, 3,4, 10, 2,8, 10, 10, 8,0, 10, 8,2, 9};
//		Assert.AreEqual(endGame, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T07GameEndAtBowl20(){
//		int[] rolls = {1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1, 1};
//		Assert.AreEqual(endGame, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T08TidyAfterBowl19Strike(){
//		int[] rolls = {1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 10,5};
//		Assert.AreEqual(tidy, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T09TidyAfterBowl19StrikeAndThenGutter(){
//		int[] rolls = {1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 10,0};
//		Assert.AreEqual(tidy, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T1019And20Strike(){
//		int[] rolls = {1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 10,10};
//		Assert.AreEqual(reset, ActionMaster.NextAction(rolls.ToList()));
//	}
//
//	[Test]
//	public void T11()
//	{
//		pinFalls.Clear ();
//		for (int i = 0; i < 18; i++)
//			pinFalls.Add(1);
//		pinFalls.Add (5);
//		Assert.AreEqual(tidy, ActionMaster.NextAction(pinFalls));
//	}
//	[Test]
//	public void T12BowlIndexTest(){
//		int[] rolls = {0,10, 5, 1};
//		Assert.AreEqual(endTurn,ActionMaster.NextAction(rolls.ToList()));
//	}
//		
//	[Test]
//	public void T13Dondi10thFrameTurkey () {
//		int[] rolls = {1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 1,1, 10, 10, 10};
//		Assert.AreEqual (endGame, ActionMaster.NextAction (rolls.ToList()));
//	}
//
//	[Test]
//	public void T14ZeroOneGivesEndTurn () {
//		int[] rolls = { 0, 1 };
//		Assert.AreEqual (endTurn, ActionMaster.NextAction (rolls.ToList()));
//	}

}