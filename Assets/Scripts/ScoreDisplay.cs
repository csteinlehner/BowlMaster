using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    public Text[] rollTexts, frameTexts;
	// Use this for initialization

    public void FillRolls(List<int> rolls)
    {
        string scoreString = FormatRolls(rolls);
        for(int i = 0; i < scoreString.Length; i++)
        {
            rollTexts[i].text = scoreString[i].ToString();
        }
    }

    public void FillFrames(List<int> frames)
    {
        for(int i = 0; i < frames.Count; i++)
        {
            frameTexts[i].text = frames[i].ToString();
        }
    }
  public static string FormatRolls(List<int> rolls)
    {
        string output = "";
        return output;
    }
}
