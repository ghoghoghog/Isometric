using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public int currenttime=90;
    private float timedown;

    private void Update()
    {
        timer.text = "Time: " + currenttime;
        
        timedown += Time.deltaTime;
        if (timedown>1)
        {
            currenttime -= 1;
            timedown = 0;
        }

        if (currenttime<=0)
        {
            SceneManager.LoadScene(sceneName: "fail");
        }
        
        
    }
}
