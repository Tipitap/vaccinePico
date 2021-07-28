using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataContent : MonoBehaviour
{
    public DataAll[] all;

    public static DataContent Instance { get; protected set; }

    [Serializable]
    public class DataAll
    {
        public Sprite logo;
        public string[] users;
    }
    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        DontDestroyOnLoad(this);
    }
    public Sprite GetLogoByUser()
    {
        string username = PlayerPrefs.GetString("username");
        Debug.Log("Get user name for logo: " + username);
        foreach(DataAll data in all)
        {
            foreach (string user in data.users)
                if (user.ToLower() == username.ToLower())
                {
                    Debug.Log("_______________logo: " + data.logo.name);
                    return data.logo;                    
                }
        }
        return null;
    }
}
