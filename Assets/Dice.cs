using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    // 選擇職業用的參數
    int minDice;
    int maxDice;
    string ocupation;
    int salary;
    int monthlyFee;

    bool isSchool = true;
    int DiceNum;
    int playerNum;
    [SerializeField]
    Map map;
    [SerializeField]
    School school;
    [SerializeField]
    PlayerState playerState;

    public Text diceNumTxt;
    public Text playerNumTxt;
    public Text placeNumTxt;
    public GameObject BtnYN;

    private void Start()
    {
        diceNumTxt.text = "DiceNum = " + DiceNum;
        playerNumTxt.text = "playerNum = " + playerNum;
        placeNumTxt.text = "placeName = " + map.placeName[playerNum];
        if (isSchool)
        {
            playerState.studentLoan += 30000;
            Debug.Log("學費 = " + playerState.studentLoan);
        }
    }

    public void RollDice()
    {
        DiceNum = Random.Range(1, 7);
        diceNumTxt.text = "DiceNum = " + DiceNum;
        Debug.Log("DiceNum = " + DiceNum);
        playerNum += DiceNum;
        DiceNum = 0;
        if (!isSchool)
        {
            if (playerNum > 35)
            {
                playerNum = playerNum % 35;
            }
            playerNumTxt.text = "playerNum = " + playerNum;
            Debug.Log("playerNum = " + playerNum);
            placeNumTxt.text = "placeName = " + map.placeName[playerNum];
            Debug.Log("placeName = " + map.placeName[playerNum]);
        }
        else if (isSchool)
        {
            if (playerNum > 16)
            {
                playerNum = playerNum % 16;
                playerState.studentLoan += 30000;
                Debug.Log("學費 = " + playerState.studentLoan);
            }
            playerNumTxt.text = "playerNum = " + playerNum;
            Debug.Log("playerNum = " + playerNum);
            placeNumTxt.text = "schoolName = " + school.schoolName[playerNum];
            Debug.Log("placeName = " + school.schoolName[playerNum]);
            SchoolEvent();
        }
    }

    public void SchoolEvent()
    {
        if (school.schoolName[playerNum] == "律師助理")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 1;
            maxDice = 2;
            ocupation = "律師助理";
            salary = 50000;
            monthlyFee = 20000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "汽車公司")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 1;
            maxDice = 4;
            ocupation = "汽車公司";
            salary = 38000;
            monthlyFee = 11000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "失戀")
        {
            // 暫停一回合
            Debug.Log("暫停一回合");
        }
        else if (school.schoolName[playerNum] == "玻璃公司")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 1;
            maxDice = 2;
            ocupation = "玻璃公司";
            salary = 44000;
            monthlyFee = 14000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "造紙，電子")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 4;
            maxDice = 6;
            ocupation = "造紙，電子";
            salary = 40000;
            monthlyFee = 12000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "打工")
        {
            DiceNum = Random.Range(1, 13);
            diceNumTxt.text = "DiceNum = " + DiceNum;
            Debug.Log("DiceNum X2 = " + DiceNum);
            playerState.cash += DiceNum * 1000;
            Debug.Log("打工赚取 = " + DiceNum * 1000);
        }
        else if (school.schoolName[playerNum] == "電子工作員")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 0;
            maxDice = 0;
            ocupation = "電子工作員";
            salary = 0;
            monthlyFee = 0;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "金融公司分析師")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 4;
            maxDice = 6;
            ocupation = "金融公司分析師";
            salary = 60000;
            monthlyFee = 20000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "營建公司工程師")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 3;
            maxDice = 6;
            ocupation = "營建公司工程師";
            salary = 45000;
            monthlyFee = 13000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "便利商店店員/清潔員工")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 0;
            maxDice = 0;
            ocupation = "便利商店店員/清潔員工";
            salary = 20000;
            monthlyFee = 10000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "教師")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 5;
            maxDice = 6;
            ocupation = "教師";
            salary = 30000;
            monthlyFee = 15000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "考試")
        {
            // 考試
            Debug.Log("考試");
        }
        else if (school.schoolName[playerNum] == "紡織公司")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 0;
            maxDice = 0;
            ocupation = "紡織公司";
            salary = 30000;
            monthlyFee = 10000;
            BtnYN.SetActive(true);
        }
        else if (school.schoolName[playerNum] == "DairyLife")
        {
            // DairyLife
            Debug.Log("DairyLife");
        }
        else if (school.schoolName[playerNum] == "醫生")
        {
            Debug.Log("接受這個職業嗎?");
            minDice = 1;
            maxDice = 2;
            ocupation = "醫生";
            salary = 80000;
            monthlyFee = 30000;
            BtnYN.SetActive(true);
        }
    }

    public void AcceptOcupation()
    {
        DiceNum = Random.Range(1, 7);
        diceNumTxt.text = "DiceNum = " + DiceNum;
        Debug.Log("DiceNum = " + DiceNum);
        if (DiceNum >= minDice && DiceNum <= maxDice || minDice==0 && maxDice==0)
        {
            isSchool = false;
            playerNum = 0;
            placeNumTxt.text = "placeName = " + map.placeName[playerNum];
            Debug.Log("placeName = " + map.placeName[playerNum]);
            playerState.ocupation = ocupation;
            Debug.Log("職業 = " + playerState.ocupation);
            playerState.salary = salary;
            Debug.Log("薪水 = " + playerState.salary);
            playerState.monthlyFee = monthlyFee;
            Debug.Log("每月支出 = " + playerState.monthlyFee);
        }
        else
        {
            Debug.Log("失敗");
        }
    }
}
