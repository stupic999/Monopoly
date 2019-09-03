using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SocketIO;
using System.Text;

public class stop : NetworkBehaviour
{
    int DiceNum;
    SocketIOComponent m_socket;
    public int playerNow;
    public Text playerNumTxt;
    string playerStringNow;

    void Start()
    {
        m_socket = GameObject.FindGameObjectWithTag("Finish").GetComponent<SocketIOComponent>();
        playerNow = 1;
        playerNumTxt = GameObject.FindGameObjectWithTag("Water").GetComponent<Text>();
        playerNumTxt.text = "現在行動玩家 = " + playerNow;
    }

    private void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        StartCoroutine(Download());
        playerNumTxt.text = "現在行動玩家 = " + playerNow;
        if (Input.GetMouseButtonDown(0))
        {
            playerNow++;
            if (playerNow > PlayerList.playerList.Count)
            {
                playerNow = 1;
            }
            User user2 = new User();
            user2.score = 0;
            user2.playerNow = playerNow;

            Debug.Log("playerNow = " + playerNow);
            playerStringNow = JsonUtility.ToJson(user2);
            StartCoroutine(Post("http://192.168.43.66:3000/user", playerStringNow));

            //    DiceNum = Random.Range(1, 7);
            //    //Debug.Log(DiceNum);
            //    Dictionary<string, string> data = new Dictionary<string, string>();
            //    data["dice"] = DiceNum.ToString();
            //    m_socket.Emit("throwDice", new JSONObject(data), OnServerListenerCallback);
            //}
        }
    }

    IEnumerator Download()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://192.168.43.66:3000/user");
        yield return www.SendWebRequest();

        // 顯示錯誤
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            User user1 = JsonUtility.FromJson<User>(www.downloadHandler.text);
            playerNow = user1.playerNow;
        }
    }

    IEnumerator Post(string url, string bodyJsonString)
    {
        var request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(bodyJsonString);
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();
        Debug.Log("Status Code: " + request.responseCode);
    }
}
