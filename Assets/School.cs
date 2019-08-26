using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour
{
    public string[] schoolName = new string[16];
    string start = "Start";
    string lawyer = "律師助理";
    string car = "汽車公司";
    string love = "失戀";
    string glass = "玻璃公司";
    string paper = "造紙，電子";
    string work = "打工";
    string elec = "電子工作員";
    string gold = "金融公司分析師";
    string build = "營建公司工程師";
    string shop = "便利商店店員/清潔員工";
    string teacher = "教師";
    string exam = "考試";
    string sew = "紡織公司";
    string dairyLife = "DairyLife";
    string doctor = "醫生";
    void Awake()
    {
        schoolName[0] = start;
        schoolName[1] = lawyer;
        schoolName[2] = car;
        schoolName[3] = love;
        schoolName[4] = glass;
        schoolName[5] = paper;
        schoolName[6] = work;
        schoolName[7] = elec;
        schoolName[8] = gold;
        schoolName[9] = build;
        schoolName[10] = shop;
        schoolName[11] = teacher;
        schoolName[12] = exam;
        schoolName[13] = sew;
        schoolName[14] = dairyLife;
        schoolName[15] = doctor;
    }
}
