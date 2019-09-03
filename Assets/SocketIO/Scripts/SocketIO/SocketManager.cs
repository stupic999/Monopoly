using SocketIO;
using System.Collections.Generic;
using UnityEngine;

namespace Tool
{
    public class SocketManager : MonoBehaviour
    {

        SocketIOComponent m_socket;

        void Start()
        {
            m_socket = GetComponent<SocketIOComponent>();

            if (m_socket != null)
            {
                //系統的事件
                m_socket.On("open", OnSocketOpen);
                m_socket.On("error", OnSocketError);
                m_socket.On("close", OnSocketClose);
                //自定義的事件
                m_socket.On("ClientListener", OnClientListener);

                Invoke("SendToServer", 3);

                m_socket.On("result", OnClientListener);
            }
        }

        // Update is called once per frame
        void Update()
        {
           
        }

        public void SendToServer()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["email"] = "some@email.com";
            m_socket.Emit("ServerListener", new JSONObject(data), OnServerListenerCallback);

            //斷開連接,會觸發close事件
            //socket.Close();
        }
        #region 註冊的事件

        public void OnSocketOpen(SocketIOEvent ev)
        {
            Debug.Log("OnSocketOpen updated socket id " + m_socket.sid);
        }

        public void OnClientListener(SocketIOEvent e)
        {
            Debug.Log(string.Format("OnClientListener name: {0}, data: {1}", e.name, e.data));
        }

        public void OnSocketError(SocketIOEvent e)
        {
            Debug.Log("OnSocketError: " + e.name + " " + e.data);
        }

        public void OnSocketClose(SocketIOEvent e)
        {
            Debug.Log("OnSocketClose: " + e.name + " " + e.data);
        }

        public void ChangeNextPlayerTurn()
        {

        }

        #endregion
        public void OnServerListenerCallback(JSONObject json)
        {
            Debug.Log(string.Format("OnServerListenerCallback data: {0}", json));
        }
    }
}