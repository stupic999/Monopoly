using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using System.Text;

class User
{
    public int score;
    public int playerNow = 1;

}

public class MyBehavior : MonoBehaviour
{
    int scoreNow;
    string scoreStringNow;

    // Start is called before the first frame update
    void Start()
    {
        // can use
        //User user2 = new User();
        //user2.score = 0;
        //user2.playerNow = 1;
        //scoreStringNow = JsonUtility.ToJson(user2);
        //StartCoroutine(Post("http://192.168.43.66:3000/user", scoreStringNow));

        // try
        //StartCoroutine(Download());
    }

    public void Update()
    {
        StartCoroutine(Download());
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
            Debug.Log(www.downloadHandler.text);
            User user1=JsonUtility.FromJson<User>(www.downloadHandler.text);
            Debug.Log(user1.score);
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

