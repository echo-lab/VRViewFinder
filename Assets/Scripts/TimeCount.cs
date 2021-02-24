using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public Text time_count;

    private float minutes, seconds;

    void Start()
    {
        time_count = GetComponent<Text>() as Text;
    }

    void Update()
    {
        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        time_count.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}

