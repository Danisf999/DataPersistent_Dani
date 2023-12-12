using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    public static DataController _instance;

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void DataSave(string key, string data)
    {
        PlayerPrefs.SetString(key, data);
    }
    public string DataLoad(string key)
    {
        return PlayerPrefs.GetString(key);
    }

    public void DataSaveInt(string key, int data)
    {
        PlayerPrefs.SetInt(key, data);
    }

    public int DataLoadInt(string key)
    {
        return PlayerPrefs.GetInt(key);
    }
}
