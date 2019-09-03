using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MoveTest : NetworkBehaviour
{
    public float speed = 3;

    stop list;

    int playerMeNum;

    GameObject self;

    public Text playerMeTxt;

    stop stoppp;

    private void Start()
    {
        stoppp = GetComponent<stop>();
        list = GetComponent<stop>();
        self = GetComponent<GameObject>();
        PlayerList.playerList.Add(self);
        playerMeNum = PlayerList.playerList.Count;
        playerMeTxt = GameObject.FindGameObjectWithTag("Fire").GetComponent<Text>();
        playerMeTxt.text = "玩家號碼 = "+playerMeNum;
}

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer || playerMeNum!=stoppp.playerNow)
        {
            return;
        }
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            transform.Translate(new Vector2(x, y) * Time.deltaTime * speed);
    }
}