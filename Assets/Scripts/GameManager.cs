using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager current;

    public Text timer; // = current.GetComponentInChildren<Text>();

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float startTime;
    private float elapsedTime;
    //timePlaying.ToString("hh': 'mm': 'ss'");

    private void Awake()
    {
        current = this;
    }

    private void Start()
    {
        timer.text = "00:00.00";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        startTime = Time.time;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            timer.text = timePlaying.ToString("mm':'ss'.'ff");

            yield return null;
        }
    }

}
