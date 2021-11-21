using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public class WebRequest: MonoBehaviour
{
    public static WebRequest instance;
    public static int boxCount;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        StartCoroutine(GetRequest("https://2nta3cfe5b.execute-api.us-east-2.amazonaws.com/prod/idaretest_1?test_name=IDARE_Test"));
    }

    static IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    proccesJsonData(webRequest.downloadHandler.text);
                    break;
            }
        }
    }

    private static void proccesJsonData(string data)
    {
        
        jsonData getData = JsonUtility.FromJson<jsonData>(data);
        boxCount = getData.boxes;
    }
}