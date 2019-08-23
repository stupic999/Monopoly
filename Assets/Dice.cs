using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    int DiceNum;
    int playerNum;
    [SerializeField]
    Map map;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
            playerNum += DiceNum;
            DiceNum = 0;
            if (playerNum > 35)
            {
                playerNum = playerNum % 35;
            }
            Debug.Log("playerNum = " + playerNum);
            Debug.Log("placeName = " + map.placeName[playerNum]);
        }
    }

    public void RollDice()
    {
        DiceNum = Random.Range(1, 7);
        Debug.Log("DiceNum = " + DiceNum);
    }
}
