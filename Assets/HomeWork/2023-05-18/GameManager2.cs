using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 :MonoBehaviour
{
    private static GameManager2 instance;
    private static HomeData homeData;
    public static GameManager2 Instance { get { return instance; } }
    public static HomeData HomeData { get { return homeData; } }

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
        instance = this;
        InitManagers();
    }
    private void OnDestroy()
    {
        if (instance == this)
            instance = null;
    }

    private void InitManagers()
    {
        GameObject homObj = new GameObject() { name = "HomeData" };
        homObj.transform.SetParent(transform);
        homeData = homObj.AddComponent<HomeData>();
    }
}
