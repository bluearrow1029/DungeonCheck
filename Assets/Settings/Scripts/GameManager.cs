using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Map map;

    public bool OpenMap = false;
    public bool isLive;

    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            OpenMap = !OpenMap;
            if(OpenMap)
            {
                map.Show();
            }
            else
            {
                map.Hide();
            }
        }
    }

    public void Stop()
    {
        isLive = false;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        isLive = true;
        Time.timeScale = 1;
    }
}
