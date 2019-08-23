using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    int DiceNum;
    int playerNum;
    [SerializeField]
    Map map;

    public Text diceNumTxt;
    public Text playerNumTxt;
    public Text placeNumTxt;

    private void Start()
    {
        diceNumTxt.text = "DiceNum = " + DiceNum;
        playerNumTxt.text = "playerNum = " + playerNum;
        placeNumTxt.text = "placeName = " + map.placeName[playerNum];
    }

    public void RollDice()
    {
        DiceNum = Random.Range(1, 7);
        diceNumTxt.text = "DiceNum = " + DiceNum;
        Debug.Log("DiceNum = " + DiceNum);
        playerNum += DiceNum;
        DiceNum = 0;
        if (playerNum > 35)
        {
            playerNum = playerNum % 35;
        }
        playerNumTxt.text = "playerNum = " + playerNum;
        Debug.Log("playerNum = " + playerNum);
        placeNumTxt.text = "placeName = " + map.placeName[playerNum];
        Debug.Log("placeName = " + map.placeName[playerNum]);
    }
}
