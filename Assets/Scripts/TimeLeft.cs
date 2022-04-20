using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timeText;

    public static float timeLeft;
    public int minuteLeft;
    public float secondLeft;

    void Start()
    {
        minuteLeft = 2;
        secondLeft = 0;

        timeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        secondLeft -= Time.deltaTime;
        if(secondLeft <= 0)
        {
            minuteLeft--;
            secondLeft += 60;
        }

        timeLeft = 60 * minuteLeft + secondLeft;

        timeText.text = "Time Left: " + minuteLeft + ":" + secondLeft;

        if(timeLeft <= 0)
        { TimeOut(); }
    }

    void TimeOut()
    {
        SceneManager.LoadScene("Defeat");
    }

    
}
