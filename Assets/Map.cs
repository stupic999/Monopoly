using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Chat log> player move
    // Serealize json object
    public string[] placeName = new string[36];
    string start = "Start";
    string dairyLife = "Dairy Life";
    string house = "House";
    string bussinessRisk = "Bussiness Risk";
    string futureMarket = "Future Market";
    string marketRisk = "Market Risk";
    string stockMarket = "Stock Market";
    string child = "Child";
    string investmentOptions="Investment Options";
    string bank = "Bank";
    string boundNFund = "Bound & Fund";
    string law = "Law";
    string cashDividend = "Cash Dividend";
    string hospital = "Hospital";
    string carShop = "Car Shop";

    void Awake()
    {
        // 第一行
        placeName[0] = start;
        placeName[1] = dairyLife;
        placeName[2] = house;
        placeName[3] = bussinessRisk;
        placeName[4] = futureMarket;
        placeName[5] = marketRisk;
        placeName[6] = stockMarket;
        placeName[7] = child;
        placeName[8] = investmentOptions;
        placeName[9] = dairyLife;

        // 第二行
        placeName[10] = bank;
        placeName[11] = stockMarket;
        placeName[12] = house;
        placeName[13] = boundNFund;
        placeName[14] = stockMarket;
        placeName[15] = investmentOptions;
        placeName[16] = dairyLife;
        placeName[17] = marketRisk;

        // 第三行
        placeName[18] = law;
        placeName[19] = "IDK!!!!!!";
        placeName[20] = futureMarket;
        placeName[21] = bussinessRisk;
        placeName[22] = boundNFund;
        placeName[23] = house;
        placeName[24] = dairyLife;
        placeName[25] = stockMarket;
        placeName[26] = marketRisk;
        placeName[27] = cashDividend;

        // 第四行
        placeName[28] = hospital;
        placeName[29] = futureMarket;
        placeName[30] = dairyLife;
        placeName[31] = bussinessRisk;
        placeName[32] = house;
        placeName[33] = investmentOptions;
        placeName[34] = marketRisk;
        placeName[35] = carShop;
    }
}
